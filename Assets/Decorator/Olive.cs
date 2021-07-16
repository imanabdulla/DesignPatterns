using UnityEngine;

public class Olive :Pizza
{
    private Pizza pizza;

public Olive(Pizza pizza)
{
    this.pizza = pizza;
    Description = " , Olive";

    for (int i = 0; i < PizzaManager.instance.oliveSpawnPoints.Length; i++)
        Instantiate(PizzaManager.instance.olivePrefab, PizzaManager.instance.oliveSpawnPoints[i].position, Quaternion.identity);
}
}
