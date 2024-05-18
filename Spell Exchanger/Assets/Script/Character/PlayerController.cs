using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : Controller
{
    public Control playerControl;


    // Start is called before the first frame update
    void Start()
    {
       if(isKeyBoard)
       {
            characterPosition = Vector2.zero;
       }
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the player want using a keyboard or the mouse to move.
        if(isKeyBoard)
        {

            if (Input.GetKey(playerControl.movement[0])) {
                characterPosition += new Vector2(0,1);
            }
            if (Input.GetKey(playerControl.movement[1]))
            {
                characterPosition += new Vector2(0, -1);
            }
            if (Input.GetKey(playerControl.movement[2]))
            {
                characterPosition += new Vector2(1, 0);
            }
            if (Input.GetKey(playerControl.movement[3]))
            {
                characterPosition += new Vector2(-1, 0);
            }
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                characterPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        
    }
}
