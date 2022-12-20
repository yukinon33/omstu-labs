namespace SpaceBattle.Lib;

public class RemovePropertyStrategy : IStrategy
{
    public object Execute(params object[] args)
    {
        var command = new RemoveProperty((IUObject)args[0], (string)args[1], (object)args[2]);
        return command;
    }
}

public class RemoveProperty : ICommand
{
    private IUObject obj;
    private string key;
    private object value;
    public RemoveProperty(IUObject obj, string key, object value)
    {   
        this.obj = obj;
        this.key = key;
        this.value = value;
    }
    public void Execute() { }
}
