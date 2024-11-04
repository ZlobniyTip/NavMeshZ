using Zenject;

public class Install : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<PlayerComponents>().FromNew().AsSingle();
        Container.Bind<IMovable>().To<NavMeshMovement>().AsSingle();
    }
}