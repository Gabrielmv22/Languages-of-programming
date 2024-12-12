using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float timer = 30f; // Tiempo inicial
    public Text timerText;    // Texto UI para mostrar el tiempo
    public ObjectSpawner objectSpawner; // Referencia al script que genera los objetos

    private bool isTimerActive = true;

    void Update()
    {
        if (isTimerActive)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = 0;
                isTimerActive = false;

                // Llamar al método que aumenta la velocidad de generación
                objectSpawner.IncreaseSpawnSpeed();
            }

            // Actualizar el texto del temporizador
            if (timerText != null)
            {
                timerText.text = Mathf.Ceil(timer).ToString();
            }
        }
    }
}
