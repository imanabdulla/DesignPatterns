using UnityEngine;

public interface IPublisher
{
    public void AddObserver(IObserver observer);
    public void NotifyObserver();
    public void RemoveObserver(IObserver observer);
}
