using TMPro;
using UnityEngine;

public class JuanSalvo : MonoBehaviour
{
    // 1. TAREA: Declarar variables para nombre, edad, altura (float).

    // Escribe tus variables aquí abajo:


    // ---------------------------------------------------------
    // (NO TOCAR)
    [Header("Referencias UI")]
    [SerializeField]
    private TextMeshProUGUI _uiText;
    private string _finalMessage;

    // ---------------------------------------------------------

    private void Start()
    {
        // Al iniciar, llamamos a la función que muestra los datos
        MostrarDatos();
    }

    public void MostrarDatos() // Renombrado de OnClick a MostrarDatos para ser más semántico si se llama en Start
    {
        // 2. TAREA: Construir la frase.
        // Asigna a la variable '_finalMessage' la concatenación de tus variables.

        // _finalMessage = ... (Escribe tu código aquí)

        // Mostrar en consola
        Debug.Log(_finalMessage);

        // ---------------------------------------------------------
        // Actualizamos la UI visualmente no hace falta tocar esto
        if (_uiText != null)
        {
            _uiText.text = _finalMessage;
        }
        else
        {
            Debug.LogError("¡Falta asignar el componente TextMeshPro al script en el Inspector!");
        }
        // ---------------------------------------------------------
    }
}
