using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformationScript : MonoBehaviour
{
    void Update()
    {
        
        //Rotate
        Quaternion q = Quaternion.Euler(0.0f, 10.0f * Time.deltaTime, 0.0f);
        Matrix4x4 matrix1 = Matrix4x4.Rotate(q);
        transform.position = matrix1.MultiplyPoint3x4(transform.position);
       
        transform.Rotate(0.0f, 30.0f * Time.deltaTime, 0.0f, Space.Self);
        
        
        //Lift-off(Fly)
        Matrix4x4 matrix2 = Matrix4x4.Translate(new Vector3(5.0f * Time.deltaTime, 5.0f * Time.deltaTime, 5.0f * Time.deltaTime));
        transform.position = matrix2.MultiplyPoint3x4(transform.position);
        
        
        //Scale
        Matrix4x4 matrix3 = Matrix4x4.Scale(new Vector3(1.001f, 1.001f, 1.001f));
        transform.localScale = matrix3.MultiplyPoint3x4(transform.localScale);
        
    }
}
