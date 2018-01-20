using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerDirtOutProx : MonoBehaviour {

    public ScriptProximityDetect wholeUnit;
    public ScriptMovePane thisLevel;

	// Update is called once per frame
	void Update () {
        if (wholeUnit.isInProx == false)
        {
            thisLevel.startMovementDown();
        }
	}
}
