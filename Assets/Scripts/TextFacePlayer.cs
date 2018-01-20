using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFacePlayer : MonoBehaviour
{
    public Transform target;
    public float damping;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lookAt();
    }

    void lookAt()
    {
        if (target != null)
        {
            transform.LookAt(target, Vector3.up);
        }
        /*
        var delta = target.position - transform.position;
        delta.z = 0;
        var rotation = Quaternion.LookRotation(delta);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        */
    }
}
