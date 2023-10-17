using RMC.Projects.Principles.SOLID.SOLID_5DependencyInversion.Player;
using RMC.Projects.Principles.SOLID.SOLID_5DependencyInversion.Player.Interfaces;
using RMC.Projects.Principles.SOLID.SOLID_5DependencyInversion.Settings;
using UnityEngine;

namespace RMC.Projects.Principles.SOLID.SOLID_5DependencyInversion
{
	/// <summary>
	/// The intention of these principles is to make software designs more understandable,
	/// easier to maintain and easier to extend.
	/// As a software engineer, these 5 principles are essential to know!
	/// See <a href="https://itnext.io/solid-principles-explanation-and-examples-715b975dcad4">docs</a>.
	///
	/// NOTE: In this Scene, we show the (D)ependency Inversion Principle.
	/// 
	/// </summary>
	public class SOLID_5DependencyInversionDemo : MonoBehaviour
	{
		[SerializeField] 
		private GameObject _bulletPrefab = null;

		[SerializeField]
		private GameObject _player = null;

		private IPlayerMover _playerMover;
		private IPlayerBoundsChecker _playerBoundsChecker;
		private IPlayerShooter _playerShooter;

		protected void Start()
		{
			PlayerSettings settings = new PlayerSettings();
			
			_playerMover = new PlayerMover(_player, _bulletPrefab, settings);
			_playerBoundsChecker = new PlayerBoundsChecker(_player, _bulletPrefab, settings);
			_playerShooter = new PlayerShooter(_player, _bulletPrefab, settings);
			
		}

		protected void Update()
		{
			_playerMover.Update();
			_playerBoundsChecker.Update();
			_playerShooter.Update();
		}
	}
}