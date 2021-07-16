using UnityEngine;
using Factory;

public class ButtonManager : MonoBehaviour
{
    public void ShowAbility(string abilityName)
    {
        AbilityFactory.GetAbility(abilityName).Process();
    }
}
