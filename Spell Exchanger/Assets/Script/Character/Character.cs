using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Player Infromations")]
    [SerializeField] protected float playerSpeed = 5.0f;
    


    [Header("Player Infromations")]
    [SerializeField] protected float cameraSpeed = 2.0f;

    [Header("Player Controller")]
    [SerializeField] public Controller characterCharacter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(characterCharacter != null)
        {
            Vector3 characterPosition = characterCharacter.characterPosition;
            if (characterCharacter.isKeyBoard)
            {
                if (characterCharacter.GetType() == typeof(PlayerController))
                {
                    transform.parent.position = Vector2.MoveTowards(transform.parent.position, transform.parent.position+characterPosition*playerSpeed, Time.deltaTime * playerSpeed);
                }
            }
            else
            {
                transform.parent.position = Vector2.MoveTowards(transform.parent.position, characterPosition, Time.deltaTime * playerSpeed);
                transform.parent.right = new Vector2(characterPosition.x - transform.parent.position.x, characterPosition.y - transform.parent.position.y);
            }
            if (characterCharacter.GetType() == typeof(PlayerController))
            {
                Vector3 cameraTarget = new Vector3(transform.parent.position.x, transform.parent.position.y, Camera.main.transform.position.z);
                Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, cameraTarget, Time.deltaTime * cameraSpeed);
            }

        }
    }
}
