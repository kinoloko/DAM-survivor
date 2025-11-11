using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    /// <summary>
    /// ///////////////////// Variables /////////////////////////
    /// </summary>
    [Header("Configuración de Spawn")]
    [SerializeField]
    private float spawnRadius = 10f;

    [Header("GameObjects")]
    [SerializeField]
    private Transform player;

    [SerializeField]
    private List<DataOleada> oleadas;


    
    ////////////////////////////////////// Funciones Unity//////////////////
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerarOleadas();
    }

    // Update is called once per frame
    void Update()
    {

    }

    ///////////////////////////// Funciones Propias ////////////////////

    private IEnumerator spawn(DataOleada oleada)
    {
        while (true)
        {
            Vector2 randomPoint = Random.insideUnitCircle * spawnRadius;
            Vector3 spawnPosition = player.position + new UnityEngine.Vector3(randomPoint.x, 0f, randomPoint.y);
            Instantiate(oleada.EnemyPrefab, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(oleada.SpawnRate);
        }
    }
    
    public void GenerarOleadas()
    {
        foreach(DataOleada oleadaActual in oleadas)
        {
            StartCoroutine(spawn(oleadaActual));
        }
    }
}
