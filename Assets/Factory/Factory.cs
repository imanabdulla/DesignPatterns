using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public abstract class Ability : MonoBehaviour
    {
        public abstract string Name { get; }

        public abstract void Process();
    }

    public class SphereAbility : Ability
    {
        public override string Name => "Sphere";

        public override void Process()
        {
            FindObjectOfType<SimpleCapsule>().ShowAbility(0);
            Debug.Log(Name);
        }
    }

    public class QuadAbility : Ability
    {
        public override string Name => "Quad";

        public override void Process()
        {
            FindObjectOfType<SimpleCapsule>().ShowAbility(1);
            Debug.Log(Name);
        }
    }

    public class CylinderAbility : Ability
    {
        public override string Name => "Cylinder";

        public override void Process()
        {
            FindObjectOfType<SimpleCapsule>().ShowAbility(2);
            Debug.Log(Name);
        }
    }

    public static class AbilityFactory
    {
        private static Dictionary<string, Type> abilitiesByName;
        private static bool IsInitialized => abilitiesByName != null;

        private static void InitializeFactory()
        {
            if (IsInitialized) return;

            var abilitiesTypes = Assembly.GetAssembly(typeof(Ability)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));

            abilitiesByName = new Dictionary<string, Type>();

            foreach (var t in abilitiesTypes)
            {
                var tempEffect = Activator.CreateInstance(t) as Ability;
                abilitiesByName.Add(tempEffect.Name, t);
            }
        }

        public static Ability GetAbility(string abilityName)
        {
            InitializeFactory();
            if (abilitiesByName.ContainsKey(abilityName))
            {
                var t = abilitiesByName[abilityName];
                var ability = Activator.CreateInstance(t) as Ability;
                return ability;
            }

            return null;
        }
    }
}