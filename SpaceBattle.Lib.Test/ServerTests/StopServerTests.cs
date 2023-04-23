namespace SpaceBattle.Lib;

public class StopServerTests
{
    [Fact]
    public void StopThreads()
    {
        new InitScopeBasedIoCImplementationCommand().Execute();
        IoC.Resolve<Hwdtech.ICommand>("Scopes.Current.Set", IoC.Resolve<object>("Scopes.New", IoC.Resolve<object>("Scopes.Root"))).Execute();

        // IoC.Resolve<Hwdtech.ICommand>("IoC.Register", "StopServerCommand", (object[] args) => StopServerStrategy().Execute(args)).Execute();
        // IoC.Resolve<Hwdtech.ICommand>("IoC.Register", "StopThreads", (object[] args) => MockStategy.Object.Execute(args)).Execute()'

    }
}