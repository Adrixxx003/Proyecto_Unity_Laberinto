using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Referencia a la esfera
    public Vector3 offset = new Vector3(0, 2, -5); // Distancia de la cámara al objetivo
    
    void LateUpdate()
    {
        if (target != null)
        {
            // Sigue la posición de la esfera con un offset
            transform.position = target.position + offset;
            
            // Mira hacia la esfera
            transform.LookAt(target);
        }
    }
}