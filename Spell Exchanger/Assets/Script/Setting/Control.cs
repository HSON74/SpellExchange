using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;
using UnityEngine.XR;

[CreateAssetMenu(fileName = "Control", menuName = "Setting/Control")]
public class Control : ScriptableObject
{
    public bool isPaused = false;
    public bool isMovementMouse = true;

    public KeyCode[] movement = { KeyCode.W, KeyCode.S, KeyCode.D, KeyCode.A };
    public KeyCode mouseMovement = KeyCode.Mouse0;
    public KeyCode swap = KeyCode.Mouse1;
    public KeyCode spellDrop = KeyCode.Q;
    public KeyCode spellSlotOne = KeyCode.Alpha1;
    public KeyCode spellSlotTwo = KeyCode.Alpha2;
    public KeyCode spellSlotThree = KeyCode.Alpha3;
    public KeyCode spellSlotFour = KeyCode.Alpha4;

}
