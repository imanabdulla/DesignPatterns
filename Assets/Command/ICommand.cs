

public interface ICommand 
{
    public string CommandName { get; }

    public void ExecuteCommand(Capsule capsule);
}
