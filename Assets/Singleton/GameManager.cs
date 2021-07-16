using UnityEngine;

public class GameManager: Singleton<GameManager>
{
    void Awake()
    {
        base.RegisterSingleton();
        //my code   
    }
}
