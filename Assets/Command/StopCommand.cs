
public class StopCommand : ICommand
{
    public string CommandName => "Stop";

    public void ExecuteCommand(Capsule capsule)
    {
        capsule.Stop();
    }

}
