using System.Collections;
using UnityEngine;

public class LanzadorArma : MonoBehaviour
{
    public GameObject armaPrefab;
    public float ratioDeDisparo = 1f; // Armas por segundo
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(dispararArma());
    }

    public IEnumerator dispararArma()
    {
        while (true)
        {
            Instantiate(armaPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(ratioDeDisparo);
        }
    }
}
