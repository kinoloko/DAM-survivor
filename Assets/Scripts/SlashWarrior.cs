using UnityEngine;

public class SlashAtaque : MonoBehaviour
{
    public int dano = 10;
    public float tiempoDeVida = 0.2f;

    void Start()
    {
        // 1. Programar la autodestrucción
        Destroy(gameObject, tiempoDeVida);
    }

    // 2. Detectar enemigos (repaso de Lección 6)
    void OnTriggerEnter(Collider other)
    {
        // Intentamos obtener el "Cerebro" del objeto con el que chocamos
        EnemyController enemigo = other.GetComponent<EnemyController>();

        // Si tiene cerebro (es un enemigo)
        if (enemigo != null)
        {
            // 3. Le hacemos daño
            enemigo.RecibirDano(dano);

            // (Opcional) ¿El slash desaparece al primer golpe o sigue activo?
            // Si quisiéramos que desapareciera:
            // Destroy(gameObject);
        }
    }
}