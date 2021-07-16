
public class CapsuleSelectionManager : Singleton<CapsuleSelectionManager>
{
    public Capsule[] capsules;
    public Capsule currentCap;

    public void SelectCapsule(Capsule cap)
    {
        foreach (var c in capsules)
            c.indicator.SetActive(false);

        cap.indicator.SetActive(true);
        currentCap = cap;
    }
}
