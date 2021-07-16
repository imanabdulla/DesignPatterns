using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandController : Singleton<CommandController>
{
    List<ICommand> commands = new List<ICommand>();

    void Start()
    {
        commands.Add(new RightCommand());
        commands.Add(new LeftCommand());
        commands.Add(new StopCommand());
    }

    public void ExecuteCommand(string commandName)
    {
        var targetCommand = commands.Find(c => c.CommandName == commandName);
        targetCommand.ExecuteCommand(CapsuleSelectionManager.instance.currentCap);
    }
}
