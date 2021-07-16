using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaManager : Singleton<PizzaManager>
{
    public Transform[] cheeseSpawnPoints;
    public Transform[] mashrumSpawnPoints;
    public Transform[] oliveSpawnPoints;
    public GameObject cheesePrefab;
    public GameObject mashrumPrefab;
    public GameObject olivePrefab;

    public Pizza referencePizza;

    private Pizza modifiedPizza;

    private void Awake()
    {
        RegisterSingleton();
    }

    public void AddCheese()
    {
         modifiedPizza = new Cheese(referencePizza);
    }

    public void AddMashrum()
    {
         modifiedPizza = new Mashrum(referencePizza);

    }

    public void AddOlive()
    {
        modifiedPizza = new Olive(referencePizza);
    }
}
