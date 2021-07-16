using UnityEngine;

public class GunBehaviour : MonoBehaviour, IPowerBehaviour
{
    public GameObject Hit()
    {
        return Instantiate(PrefabsContainer.instance.gunPrefab);
    }
}

public class SwordBehaviour : MonoBehaviour, IPowerBehaviour
{
    public GameObject Hit()
    {
        return Instantiate(PrefabsContainer.instance.swordPrefab);
    }
}

public class HandBehaviour : MonoBehaviour, IPowerBehaviour
{
    public GameObject Hit()
    {
        return Instantiate(PrefabsContainer.instance.handPrefab);
    }
}