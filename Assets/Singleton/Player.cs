using UnityEngine;

public class Player : Singleton<Player>
{
    void Awake()
    {
        base.RegisterSingleton();
        //my code   
    }
}
