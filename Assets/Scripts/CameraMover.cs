using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform target; 
    public Transform Target2;

    [SerializeField] private float Timer = 0;
    [SerializeField] private float RotateSpeed = 1;
    [SerializeField] Vector3 offsetPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer < 8)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
            Vector3 lTargetDir = target.position - transform.position;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * RotateSpeed);
        }

         if (Timer > 8 && Timer < 30)
        {
            transform.position = Vector3.Lerp(transform.position, Target2.position, Time.deltaTime);
            Vector3 lTargetDir = target.position - transform.position;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * RotateSpeed);
        }

        if (Timer > 30)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
            Vector3 lTargetDir = target.position - transform.position;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * RotateSpeed);
        }
    }
}