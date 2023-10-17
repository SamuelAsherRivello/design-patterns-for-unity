using RMC.Projects.Principles.SOLID.SOLID_5DependencyInversion.Player.Interfaces;
using RMC.Projects.Principles.SOLID.SOLID_5DependencyInversion.Settings;
using UnityEngine;

namespace RMC.Projects.Principles.SOLID.SOLID_5DependencyInversion.Player
{
    public abstract class PlayerManager : IPlayerUpdate
    {
        protected GameObject _player;
        protected GameObject _bulletPrefab;
        protected PlayerSettings _settings;

        public PlayerManager(GameObject player, GameObject bulletPrefab, PlayerSettings settings)
        {
            _player = player;
            _bulletPrefab = bulletPrefab;
            _settings = settings;
        }

        public abstract void Update();
    }
}