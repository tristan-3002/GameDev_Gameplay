// The C# script GameplayController in Unity is responsible for calling the C++ functions from the plugin.
The [DllImport] attribute is used to import the C++ functions MovePlayer and FireWeapon into the C# script.
In the Start() method, MovePlayer is called with specific coordinates to move the player at the start of the game.
In the Update() method, FireWeapon is triggered when the player presses the "Fire1" button (typically left mouse click).
  //Simply use this script in whatever GameObject you choose in your project.




using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    [DllImport("YourPluginName", CallingConvention = CallingConvention.Cdecl)]
    private static extern void MovePlayer(float x, float y, float z);

    [DllImport("YourPluginName", CallingConvention = CallingConvention.Cdecl)]
    private static extern void FireWeapon();

    // Example usage in Unity methods
    void Start()
    {
        MovePlayer(10.0f, 0.0f, 5.0f);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireWeapon();
        }
    }
}
