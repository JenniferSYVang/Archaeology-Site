using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptProximityDetect : MonoBehaviour {
    public Transform player;
    public float proximityDistance;

 //   public GameObject level1;
 //   public GameObject level2;
 //   public GameObject level3;
 //   private ScriptMovePane level1Script;
 //   private ScriptMovePane level2Script;
 //   private ScriptMovePane level3Script;
    public bool isInProx = false;

    // Use this for initialization
    void Start () {
     //   level1Script = GameObject.Find("Unit 1 Level 1").GetComponent<ScriptMovePane>();
     //   level2Script = GameObject.Find("Unit 1 Level 2").GetComponent<ScriptMovePane>();
     //   level3Script = GameObject.Find("Unit 1 Level 3").GetComponent<ScriptMovePane>();
    }

    // Update is called once per frame
    void Update() {
        if (Vector3.Distance(player.position, this.transform.position) <= proximityDistance)
        {
            isInProx = true;
        }
        else
        {
            isInProx = false;
        }

        /*if ((player.transform.position - this.transform.position).sqrMagnitude < proximityDistance)
          {
              Debug.Log("Player within proximity");
         //     level1Script.startMovementUp();
         //     level2Script.startMovementUp();
         //     level3Script.startMovementUp();
              isInProx = true;

          } else
          {
              Debug.Log("Player outside proximity");
              //   level1Script.startMovementDown();
              //   level2Script.startMovementDown();
              //   level3Script.startMovementDown();
              isInProx = false;

          }*/
    }
}
