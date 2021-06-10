using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaion : MonoBehaviour
{
    public Transform target;
    public int speed = 10;
    void Start()
    {
        if (target != null) return;
        target = gameObject.transform;
    }


    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}


