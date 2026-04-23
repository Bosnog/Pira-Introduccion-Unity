using UnityEngine;
using UnityEngine.UI;

public class LogButtons : MonoBehaviour
{
    // TAREA 1: Haz que este botón muestre un mensaje normal en consola (color blanco)
    public void ShowLogInfoMessage()
    {
        // Escribe tu código aquí:
        Debug.Log("El personaje esta satisfecho.");
    }

    // TAREA 2: Haz que este botón muestre una ADVERTENCIA (triángulo amarillo)
    public void ShowLogWarningMessage()
    {
        // Escribe tu código aquí:
        Debug.LogWarning("El personaje tiene un poco de hambre.");
    }

    // TAREA 3: Haz que este botón muestre un ERROR (octágono rojo)
    // PLUS: Investiga cómo hacer que Unity se PAUSE automáticamente al pulsar este botón.
    public void ShowLogErrorMessage()
    {
        // Escribe tu código aquí:
        Debug.LogError("ERROR");
        Debug.Break;
    }
}
