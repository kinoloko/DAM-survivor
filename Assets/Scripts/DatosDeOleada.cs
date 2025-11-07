using UnityEngine;

[CreateAssetMenu(fileName = "NuevaOleada", menuName = "Sistema de oleadas")]
public class DatosDeOleada : ScriptableObject
{
    [Header("Configuracion de la oleada")]
    public GameObject enemigoPrefab; //¿Qué enemigo vamos a generar?
    public int CantidadAGenerar; //¿Cuántos vamos a generar, escribe -1 para infinito?
    public float TiempoEntreSpawns; //¿Cada cuánto tiempo vamos a generar los enemigos? 0 = generación instántanea
}