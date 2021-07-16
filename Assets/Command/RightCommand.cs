
public class RightCommand : ICommand
{
    public string CommandName => "Right";

    public void ExecuteCommand(Capsule capsule)
    {
        capsule.MoveRight();
    }
}
