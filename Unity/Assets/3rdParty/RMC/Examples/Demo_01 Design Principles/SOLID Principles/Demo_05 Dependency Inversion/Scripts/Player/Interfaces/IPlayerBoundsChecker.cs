namespace RMC.Examples.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces
{
    public interface IPlayerBoundsChecker : IPlayerUpdate
    {
        void CheckBounds();
    }
}