using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float fuerzaMovimiento = 10f;
    private Rigidbody rb;

    void Start()
    {
        // Obtener el componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movimiento = Vector3.zero;

        // Detectar cada tecla específicamente
        if (Input.GetKey(KeyCode.W)) // Adelante
        {
            movimiento.z += 1f;
        }
        if (Input.GetKey(KeyCode.S)) // Atrás
        {
            movimiento.z -= 1f;
        }
        if (Input.GetKey(KeyCode.D)) // Derecha
        {
            movimiento.x += 1f;
        }
        if (Input.GetKey(KeyCode.A)) // Izquierda
        {
            movimiento.x -= 1f;
        }

        // Normalizar el vector para movimiento diagonal
        if (movimiento.magnitude > 0)
        {
            movimiento.Normalize();
        }

        // Aplicar fuerza al Rigidbody
        rb.AddForce(movimiento * fuerzaMovimiento);
    }
}