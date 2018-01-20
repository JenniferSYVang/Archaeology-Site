using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMenuRotate : MonoBehaviour
{
    public Transform player;
    public MeshRenderer dataTable;

    // Use this for initialization
    void Start()
    {
        dataTable.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform != null)
        {
            transform.LookAt(player);

        }

        /*
       if ((player.transform.position - this.transform.position).sqrMagnitude < proximityDistance)
       {
           Debug.Log("Player moving, adujust table movement.");

       }
       else
       {
           Debug.Log("Player outside proximity");
           level1Script.startMovementDown();
           level2Script.startMovementDown();
           level3Script.startMovementDown();
       }*/
    }
}
