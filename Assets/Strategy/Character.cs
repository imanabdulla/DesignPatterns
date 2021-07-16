using UnityEngine;

public class Character : MonoBehaviour
{
    public Transform powerSpawner;
    public Transform flightSpawner;

    protected IPowerBehaviour powerBehaviour;
    protected IFlightBehaviour flightBehaviour;

    protected void PerformHit()
    {
        powerBehaviour.Hit().transform.position = powerSpawner.position;
    }

    protected void PerformFly()
    {
        flightBehaviour.Fly().transform.position = flightSpawner.position;
    }
}
