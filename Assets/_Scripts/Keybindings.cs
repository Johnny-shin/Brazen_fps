using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Keybinding", menuName = "keybindings")]
public class Keybindings : ScriptableObject
{
    public KeyCode up, down, left, right, jump, sprint, crouch, riple, pistol, knife, grenade;

    public KeyCode CheckKey(string key)
    {
        switch (key)
        {
            case "up":
                return up;
            case "down":
                return down;
            case "left":
                return left;
            case "right":
                return right;
            case "jump":
                return jump;
            case "sprint":
                return sprint;
            case "crouch":
                return crouch;
            case "riple":
                return riple;
            case "pistol":
                return pistol;
            case "knife":
                return knife;
            case "grenade":
                return grenade;
            default:
                return KeyCode.None;

        }
    }
}
