using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
 // uso [SerializeField] para que unity pueda acceder a mi variable aunque sea privada
    [SerializeField] private float velocidadDeMovimiento;

    [SerializeField] private Vector2 direccion;

    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadDeMovimiento * Time.fixedDeltaTime);
    }
}
