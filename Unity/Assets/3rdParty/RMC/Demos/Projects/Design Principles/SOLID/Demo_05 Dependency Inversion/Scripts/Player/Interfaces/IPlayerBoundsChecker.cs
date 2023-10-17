namespace RMC.Projects.Principles.SOLID.SOLID_5DependencyInversion.Player.Interfaces
{
    public interface IPlayerBoundsChecker : IPlayerUpdate
    {
        void CheckBounds();
    }
}