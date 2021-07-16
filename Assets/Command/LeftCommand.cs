
public class LeftCommand : ICommand
{
    public string CommandName => "Left";

    public void ExecuteCommand(Capsule capsule)
    {
        capsule.MoveLeft();
    }
}
