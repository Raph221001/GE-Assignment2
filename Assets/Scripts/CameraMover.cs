using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform BaseTarget;
    public Transform CameraTarget1;
    public Transform CameraTarget2;
    public Transform CameraTarget3;
    public Transform CameraTarget4;

    [SerializeField] Vector3 offsetPos;
    [SerializeField] private float Timer = 0;
    [SerializeField] private float RotateSpeed = 1;
    
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer < 3)
        {
            transform.position = Vector3.Slerp(transform.position, BaseTarget.position+offsetPos, Time.deltaTime); 
            
            Vector3 lTargetDir = CameraTarget1.position - transform.position;
            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * RotateSpeed);
        }
        
        if (Timer > 3 && Timer < 15)
        {
            transform.position = Vector3.Slerp(transform.position, CameraTarget1.position+offsetPos, Time.deltaTime);
            transform.LookAt(CameraTarget1); 
            
            Vector3 lTargetDir = CameraTarget1.position - transform.position;
            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * RotateSpeed);
        }

        if (Timer > 15 && Timer < 25)
        {
            transform.position = Vector3.Slerp(transform.position, CameraTarget2.position+offsetPos, Time.deltaTime);
            
            Vector3 lTargetDir = CameraTarget2.position - transform.position;
            
            transform.LookAt(CameraTarget2); 
        }
        
        if (Timer > 25 && Timer < 35)
        {
            transform.position = Vector3.Slerp(transform.position, CameraTarget3.position+offsetPos, Time.deltaTime);
            transform.LookAt(CameraTarget3); 
            
            Vector3 lTargetDir = CameraTarget3.position - transform.position;
            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * RotateSpeed);
        }
        
        if (Timer > 35 && Timer < 45)
        {
            transform.position = Vector3.Slerp(transform.position, CameraTarget4.position+offsetPos, Time.deltaTime);
            transform.LookAt(CameraTarget4); 
            
            Vector3 lTargetDir = CameraTarget4.position - transform.position;
            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * RotateSpeed);
        }

        if (Timer > 45 && Timer < 70)
        {
            transform.position = Vector3.Slerp(transform.position, CameraTarget1.position+offsetPos, Time.deltaTime);
            transform.LookAt(CameraTarget1); 
            
            Vector3 lTargetDir = CameraTarget1.position - transform.position;
            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * RotateSpeed);
        }
        
    }
}
