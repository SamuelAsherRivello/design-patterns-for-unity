namespace RMC.Examples.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces
{
    public interface IPlayerShooter : IPlayerUpdate
    {
        void Shoot();
    }
}