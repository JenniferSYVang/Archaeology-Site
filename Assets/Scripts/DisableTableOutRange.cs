using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Menu;

public class DisableTableOutRange : MonoBehaviour {
    public ScriptProximityDetect inRange;
    public MeshRenderer dataTable;
    public AfterDirtSelectionShowDT scriptToLookforBool;
	
	// Update is called once per frame
	void Update () {
		if(inRange.isInProx == false && scriptToLookforBool.thisLevelWasSelected == true)
        {
            dataTable.enabled = false;
            
            scriptToLookforBool.thisLevelWasSelected = false;

        }
	}
}
