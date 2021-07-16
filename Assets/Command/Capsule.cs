using UnityEngine;

public class Capsule : MonoBehaviour
{
    Vector3 moveDirection;
    public GameObject indicator;

    private void Update()
    {
        transform.position += moveDirection * Time.deltaTime;        
    }

    private void OnMouseDown()
    {
        CapsuleSelectionManager.instance.SelectCapsule(this);
    }

    public void MoveLeft()
    {
        moveDirection = -Vector3.right;
    }

    public void MoveRight()
    {
        moveDirection = Vector3.right;
    }

    public void Stop()
    {
        moveDirection = Vector3.zero;
    }
}
