using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MovePaneWithProx : MonoBehaviour
{

    public Transform downLocation;
    public float speed;
    public ScriptProximityDetect wholeUnit;

    private Vector3 startPosition;
    enum Status { UP, DOWN };
    private Status status;

    // Use this for initialization
    void Awake()
    {

        startPosition = this.transform.position;    // save the starting location

        Debug.Log("The start position in Awake() is " + startPosition + " ---");

        transform.position = downLocation.transform.position; // setting units to start at a single point
                                                              // appearTime = DateTime.Now;


    }


    // Update is called once per frame
    void Update()
    {
        
        if(wholeUnit.isInProx == true)
        {
            RaiseUnit();
        }

        if(wholeUnit.isInProx == false)
        {
            LowerUnit();
        }
    }

    private void RaiseUnit()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, startPosition, step);
        //Debug.Log("In RaiseUnit() method ");
    }
    private void LowerUnit()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, downLocation.position, step);
        //Debug.Log("Update moving to down location with y=" + downLocation.position.y);  
    }

   /* public void startMovementUp()
    {
        Debug.Log("In the startMovementUp() method. About to raise unit.");
        status = Status.UP;
    }
    public void startMovementDown()
    {
        Debug.Log("In the startMovementDown() method. About to raise unit.");
        status = Status.DOWN;
    }*/
}
