using UnityEngine;

public class Cube : MonoBehaviour, IObserver
{
    public float speed;
    public CubeManager publisher;

    private void Awake()
    {
        //event subscriber
        publisher.AddObserver(this);
    }

    public void UpdateObserver(int direction)
    {
        this.transform.Translate(transform.right * speed * direction * Time.deltaTime);
    }
}
