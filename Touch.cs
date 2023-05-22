using UnityEngine;

public class TouchInputExample : MonoBehaviour
{
    private void Update()
    {
        // Verificar si se ha tocado la pantalla
        if (Input.touchCount > 0)
        {
            // Obtener el primer toque registrado
            Touch touch = Input.GetTouch(0);

            // Verificar el estado del toque
            if (touch.phase == TouchPhase.Began)
            {
                // Se ha iniciado el toque
                Debug.Log("Toque iniciado en la posición: " + touch.position);
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                // El dedo se ha movido mientras se mantiene el toque
                Debug.Log("Toque movido a la posición: " + touch.position);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                // El toque ha finalizado
                Debug.Log("Toque finalizado en la posición: " + touch.position);
            }
        }
    }
}
