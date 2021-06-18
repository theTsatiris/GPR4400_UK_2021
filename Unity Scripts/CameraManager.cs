using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform target;
    public float cameraRotationSpeed;
    [Range(0f,1f)]
    public float cameraSmoothTime;
    public Vector3 cameraOffset;

    CameraFollow cameraFollow;

    private void Awake()
    {
        cameraFollow = GetComponent<CameraFollow>();
    }

    /* Called in late update so that it doesn't interfere with movements, this ensures that the movements and the camera never
     fight over which happens first and it remains consistent
    Late update is called after update*/
    private void LateUpdate()
    {
        cameraFollow.HandleFollow(target,cameraRotationSpeed, cameraOffset, cameraSmoothTime);
    }

    
}
