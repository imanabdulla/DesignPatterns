using UnityEngine;

public class PrefabsContainer : Singleton<PrefabsContainer>
{
    public GameObject wingsPrefab;
    public GameObject reocketPrefab;
    public GameObject gunPrefab;
    public GameObject swordPrefab;
    public GameObject handPrefab;
    public GameObject emptyPrefab;


    private void Awake()
    {
        RegisterSingleton();
    }
}
