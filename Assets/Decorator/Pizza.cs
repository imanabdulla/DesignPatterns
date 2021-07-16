using UnityEngine;

public class Pizza : MonoBehaviour
{
    public string Description { get { return description; } set { description += value; } }

    private string description = "Pizza With ";
}
