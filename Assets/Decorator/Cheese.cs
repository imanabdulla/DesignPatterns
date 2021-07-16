using UnityEngine;

public class Cheese : Pizza
{
    private Pizza pizza;

    public Cheese(Pizza pizza)
    {
        this.pizza = pizza;
        Description = " , Cheese";

        for (int i = 0; i < PizzaManager.instance.cheeseSpawnPoints.Length; i++)
            Instantiate(PizzaManager.instance.cheesePrefab, PizzaManager.instance.cheeseSpawnPoints[i].position, Quaternion.identity);
    }
}
