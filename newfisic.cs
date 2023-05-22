using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
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
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
            // Este codigo sirve para poder dar vida a las animaciones atravez de un boolean
            gameObject.GetComponent<Animator>().SetBool("move",true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("right")) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
              // Este codigo sirve para poder dar vida a las animaciones atravez de un boolean
            gameObject.GetComponent<Animator>().SetBool("move", true);
            // Este codigo rota la animacion 
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            //con este codigo nos aseguramos que si no se esta moviendo que no haga animacion alguna
            gameObject.GetComponent<Animator>().SetBool("move", false);
        }
        if (Input.GetKeyDown("up") && canJump )
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100f));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump=true;
    }

}