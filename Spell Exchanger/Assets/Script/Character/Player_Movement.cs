using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [Header("Player Infromations")]
    [SerializeField] protected float playerSpeed = 5.0f;



    [Header("Player Infromations")]
    [SerializeField] protected float cameraSpeed = 2.0f;


    [SerializeField]
    Vector2 p_Mouse_Positon = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) {
            p_Mouse_Positon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            transform.position = Vector2.MoveTowards(transform.position, p_Mouse_Positon, Time.deltaTime*playerSpeed);
            transform.right = new Vector2(p_Mouse_Positon.x - transform.position.x, p_Mouse_Positon.y - transform.position.y);
            

            Vector3 cameraTarget = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
            
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, cameraTarget, Time.deltaTime*cameraSpeed);
        }
        
    }
}
