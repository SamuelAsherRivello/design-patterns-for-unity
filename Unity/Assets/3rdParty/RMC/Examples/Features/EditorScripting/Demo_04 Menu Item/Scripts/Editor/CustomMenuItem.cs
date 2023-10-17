using RMC.Projects.UnityDesignPatterns.Shared;
using UnityEditor;
using UnityEngine;

namespace RMC.Projects.Features.EditorScripting.Demo_04_MenuItem
{
	/// <summary>
	/// Render menu items in the top-bar Unity app menu.
	/// 
	/// You can add keyboard shortcuts too.
	/// See <a href="https://learn.unity.com/tutorial/editor-scripting#5c7f8528edbc2a002053b5f9">article</a>.
	/// 
	/// </summary>
	public class CustomMenuItem : Editor
	{
		// SHOW MENU ITEM
		[MenuItem(UnityDesignPatternsConstants.MenuItemPath + 
			"Features/EditorScripting/Demo_04_MenuItem/(+) Add Cube To Scene", priority = 0)]
		private static void AddCubeToScene()
		{
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.AddComponent<MyCustomCube>();

		}

		// SHOW MENU ITEM
		[MenuItem(UnityDesignPatternsConstants.MenuItemPath + 
			"Features/EditorScripting/Demo_04_MenuItem/(-) Remove Cube From Scene", priority = 0)]
		private static void RemoveCubeFromScene()
		{
			MyCustomCube[] myCustomCubes = GameObject.FindObjectsOfType<MyCustomCube>();

			if (myCustomCubes.Length == 0)
			{
				return;
			}

			// Unity has 2 ways to destroy depending on isPlaying
			if (Application.isPlaying)
			{
				Destroy(myCustomCubes[myCustomCubes.Length - 1].gameObject);
			}
			else
			{
				DestroyImmediate(myCustomCubes[myCustomCubes.Length - 1].gameObject);
			}
		}
		
		// TOGGLE MENU ITEM ENABLED
		[MenuItem(UnityDesignPatternsConstants.MenuItemPath + 
			"Features/EditorScripting/Demo_04_MenuItem/(-) Remove Cube From Scene", true, priority = 0)]
		private static bool RemoveCubeFromScene_Toggle()
		{
			MyCustomCube[] myCustomCubes = GameObject.FindObjectsOfType<MyCustomCube>();

			// Return TRUE to enable
			return myCustomCubes.Length > 0;
		}
	}
}