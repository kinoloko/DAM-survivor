using UnityEngine;

public class EnemyController : MonoBehaviour
{
    /// <summary>
    /// ////////////////////////////////// Variables ///////////////////////
    /// </summary>
    private GameObject player;
    private Transform objetivo;
    [SerializeField]
    private float velocidadMovimiento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        objetivo = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            //Cojo la direccion
            Vector3 direccion = objetivo.position - transform.position;
            direccion.Normalize();

            //Moverme hacia el jugador
            transform.position += direccion * velocidadMovimiento * Time.deltaTime;

        }
    }
}
