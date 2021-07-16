using UnityEngine;

public class Character1 : Character
{
    void Start()
    {
        powerBehaviour = new GunBehaviour();
        flightBehaviour = new FlightWithWrings();

        PerformHit();
        PerformFly();
    }
}
