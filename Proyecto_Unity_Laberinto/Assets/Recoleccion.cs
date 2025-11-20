using UnityEngine;
using TMPro; // Necesario para interactuar con el texto TextMeshPro

public class Recoleccion : MonoBehaviour
{
    // Campo público para enlazar el objeto de texto desde el Inspector
    public TextMeshProUGUI coinTextUI;

    // Variable privada para almacenar la cuenta
    private int coinsCollected = 0;

    void Start()
    {
        // Inicializa el texto de la UI al iniciar
        UpdateCoinText();
    }

    // Se activa cuando el Collider de este objeto (Pelota) toca un Trigger
    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que tocamos tiene la etiqueta "Coin"
        if (other.gameObject.CompareTag("Coin"))
        {
            // 1. Incrementa el contador
            coinsCollected++;

            // 2. Actualiza el texto en la pantalla
            UpdateCoinText();

            // 3. Destruye la moneda para que desaparezca
            Destroy(other.gameObject);
        }
    }

    void UpdateCoinText()
    {
        // Cambia el texto de la UI para reflejar el puntaje actual
        if (coinTextUI != null)
        {
            coinTextUI.text = "Monedas: " + coinsCollected.ToString();
        }
    }
}