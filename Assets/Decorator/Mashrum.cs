using UnityEngine;

public class Mashrum : Pizza
{
    private Pizza pizza;

    public Mashrum(Pizza pizza)
    {
        this.pizza = pizza;
        Description = " , Mashrum";

        for (int i = 0; i < PizzaManager.instance.mashrumSpawnPoints.Length; i++)
            Instantiate(PizzaManager.instance.mashrumPrefab, PizzaManager.instance.mashrumSpawnPoints[i].position, Quaternion.identity);
    }
}