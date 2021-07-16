using UnityEngine;

public class Character2 : Character
{
    void Start()
    {
        powerBehaviour = new SwordBehaviour();
        flightBehaviour = new FlightWithRocket();

        PerformHit();
        PerformFly();
    }
}
