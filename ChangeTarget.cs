using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTarget : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        if (target != null) return;
        else
        {
            target = gameObject;
        }

    }


    private void OnMouseDown()
    {
        FollowTarget.target = target;


        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
    }
}
