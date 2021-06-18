using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Vector3 cameraFollowVelocity = Vector3.zero;

    /// <summary>
    /// This is just for encapsulation purposes, it means that the other functions can remain private and it is easier to call from other scripts. 
    /// </summary>
    public void HandleFollow(Transform target, float cameraRotationSpeed, Vector3 offset, float cameraSmoothTime)
    {
        TrackTarget(target, cameraRotationSpeed);
        FollowTarget(target, offset, cameraSmoothTime);



    }


    /// <summary>
    /// This handles camera rotation so that the target is always in sight 
    /// </summary>
    /// <param name="target">this is the transform that the camera should look at</param>
    /// <param name="cameraRotationSpeed">This is the speed at which the camera should rotate in order to look at the target</param>
    private void TrackTarget(Transform target, float cameraRotationSpeed)
    {
        Quaternion targetRot = Quaternion.LookRotation(target.position - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, cameraRotationSpeed * Time.deltaTime);

    }

    
    /// <summary>
    /// This handles the cameras postion so as to always keep pace with the target
    /// </summary>
    /// <param name="target">This is the transform the camera should follow</param>
    /// <param name="offset">The offset is added to targets postion so that the camera aims for a spot that isn't inside the target</param>
    /// <param name="cameraSmoothTime">The amount of time it should take to smooth the movement</param>
    private void FollowTarget(Transform target, Vector3 offset, float cameraSmoothTime)
    {
        Vector3 targetPos = target.position + offset;
        targetPos = Vector3.SmoothDamp(transform.position, targetPos, ref cameraFollowVelocity, cameraSmoothTime);

        transform.position = targetPos;
    }

    public void CameraShake()
    {

    }
}
