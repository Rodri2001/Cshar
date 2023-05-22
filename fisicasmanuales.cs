using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canJump;

    void Start() { 
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-50f * Time.deltaTime,0 , 0);
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
        }
        ManageJump();
    }
    void ManageJump()
    {
        // este codigo lo que hace es verificar la posicion de y que es la altura hacia arriba 
        // si la posicion menor o igual a 0 que le permita saltar
        if (gameObject.transform.position.y <= 0)
        {
            canJump = true;
        }
        // este codigo lo que hace es darle un input al salto para que pueda ejecutarlo
        if (Input.GetKey("up") && canJump && gameObject.transform.position.y < 10)
        {
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0 );

        }
        else
        {
            // este codigo lo que hace es verificar si el salto esta en negativo , que traiga hacia abajo al personaje 
            canJump = false;
            if(gameObject.transform.position.y > 0)
            {
                gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
            }
        }
    }
}
