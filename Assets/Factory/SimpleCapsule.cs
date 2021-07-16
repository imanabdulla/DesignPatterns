using UnityEngine;

public class SimpleCapsule : MonoBehaviour
{
    public GameObject[] abilities;

    public void ShowAbility(int index)
    {
        foreach (var ab in abilities)
            ab.SetActive(false);

        abilities[index].SetActive(true);
    }
}
