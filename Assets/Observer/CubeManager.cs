using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour, IPublisher
{
    private List<IObserver> observers = new List<IObserver>();
    private int direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            SetDirection(1);
        else if (Input.GetKey(KeyCode.LeftArrow))
            SetDirection(-1);
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        foreach (var o in observers)
        {
            o.UpdateObserver(direction);
        }
    }

    private void SetDirection(int _direction)
    {
        this.direction = _direction;
        //event firing
        NotifyObserver();
    }
}
