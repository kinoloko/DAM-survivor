using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    /// <summary>
    /// ///////////////////// Variables /////////////////////////
    /// </summary>
    private float spawnTime = 2f;
    private float spawnTime2 = 3f;
    private float spawnRadius = 10f;
    [SerializeField]
    private Transform player;
    [SerializeField]
    private GameObject enemigo1;
    [SerializeField]
    private GameObject enemigo2;
    ////////////////////////////////////// Funciones Unity//////////////////
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawn(enemigo1, spawnTime));
        StartCoroutine(spawn(enemigo2, spawnTime2));
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    ///////////////////////////// Funciones Propias ////////////////////
    
    private IEnumerator spawn(GameObject enemigoSpawn, float tiempoSpawn)
    {
        while (true)
        {
            Vector2 randomPoint = Random.insideUnitCircle * spawnRadius;
            Vector3 spawnPosition = player.position + new UnityEngine.Vector3(randomPoint.x, 0f, randomPoint.y);
            Instantiate(enemigoSpawn, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(tiempoSpawn);
        }
    }
}
