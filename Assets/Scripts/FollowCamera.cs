using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    ///////////////////////////// Variables ///////////////////////
    /// 
    public GameObject player; // Reference to the player GameObject
    private Vector3 offset;    // Offset position from the player
    //Cargar Controles
    private Controles controles;

    //Variables zoom
    private float zoomMin = 0.5f;
    private float zoom=1f;
    private float zoomMax = 2f;
    private float suavizadoZoom = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake() {
    
    controles = new Controles();
    
    }

    void OnEnable()
    {
        controles.Enable();
    }

    private void OnDisable() {
        controles.Disable();
    }
    
        
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate() {
        float scrollValue = controles.Camera.Zoom.ReadValue<float>();
        zoom -= scrollValue / suavizadoZoom;
        zoom = Mathf.Clamp(zoom, zoomMin, zoomMax);
        Vector3 zoomFinal = offset * zoom;
        transform.position = player.transform.position + zoomFinal;
        
    }

    private void OnScroll(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        float scrollValue = context.ReadValue<float>();
        zoom -= scrollValue;
        zoom = Mathf.Clamp(zoom, zoomMin, zoomMax);
    }
   
}
