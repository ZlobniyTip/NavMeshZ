using Zenject;

public class Install : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IMovable>().To<NavMeshMovement>().AsSingle();
    }
}