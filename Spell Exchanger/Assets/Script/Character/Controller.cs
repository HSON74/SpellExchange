using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    /*
     *0 = Interaction with object
     *1 = Drop the object from inventory
     *2 = Interaction with Character
     *3 = Cast Spell one or Use item one
     *4 = Cast Spell two or Use item two
     *5 = Cast Spell three or Use item three
     *6 = Cast Spell four or Use item four
     *7 = 
     *8 = 
     *9 = 
     */
    public bool[] buttonInput = new bool[10];

    //The movement of the AI or Player
    public bool isMouseControl = false;
    public bool isKeyBoard = false;
    public Vector2 characterPosition = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
        for (int i = 0; i < buttonInput.Length; i++) {
            buttonInput[i] = false;
        }
        if(isKeyBoard)
        {
            characterPosition = Vector2.zero;
        }
    }
}
