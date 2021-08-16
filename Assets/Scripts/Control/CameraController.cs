using UnityEngine;

/* Makes the camera follow the player */

public class CameraController : MonoBehaviour
{

    public Transform target;

    
    public float smoothSpeed = 2f;
    public float yawSpeed = 70;
    

    

  
    
    void LateUpdate()
    {
        
        transform.LookAt(target.position);

        float yawInput = Input.GetAxisRaw("Horizontal");
        transform.RotateAround(target.position, Vector3.up, +yawInput * yawSpeed * Time.deltaTime);
    }

}

