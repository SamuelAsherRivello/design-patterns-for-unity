namespace RMC.Examples.DesignPrinciples.SOLID.DependencyInversionPrinciple.Player.Interfaces
{
    public interface IPlayerMover : IPlayerUpdate
    {
        void Move();
    }
}