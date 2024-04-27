// The C++ plugin contains two functions: MovePlayer and FireWeapon.
These functions are marked for export using __declspec(dllexport) to make them accessible from outside the DLL.
MovePlayer takes three float parameters (x, y, z) to simulate moving the player to a specific position in the game.
FireWeapon is a simple function that prints a message indicating that the player fired their weapon.
This script is to use for a 3D fps game project. Feel free to change some things if needed.




#include <iostream>
#include <string>

extern "C" {
    __declspec(dllexport) void MovePlayer(float x, float y, float z) {
        std::cout << "Player moved to position: (" << x << ", " << y << ", " << z << ")" << std::endl;
    }

    __declspec(dllexport) void FireWeapon() {
        std::cout << "Player fired the weapon!" << std::endl;
    }
}
