using UnityEngine;

public class FlightWithWrings : MonoBehaviour, IFlightBehaviour
{
    public GameObject Fly()
    {
        return Instantiate(PrefabsContainer.instance.wingsPrefab);
    }
}


public class FlightWithRocket : MonoBehaviour, IFlightBehaviour
{
    public GameObject Fly()
    {
        return Instantiate(PrefabsContainer.instance.reocketPrefab);
    }
}

public class CantFly : MonoBehaviour, IFlightBehaviour
{
    public GameObject Fly()
    {
        return Instantiate(PrefabsContainer.instance.emptyPrefab);
    }
}