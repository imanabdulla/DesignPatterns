using UnityEngine;

public class Character3 : Character
{
    void Start()
    {
        powerBehaviour = new HandBehaviour();
        flightBehaviour = new CantFly();

        PerformHit();
        PerformFly();
    }
}
