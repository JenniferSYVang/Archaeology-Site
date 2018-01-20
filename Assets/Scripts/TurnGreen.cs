using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Menu;

public class TurnGreen : MonoBehaviour
{
    public bool selected = false;
    public AfterSignSelectionRaise lowestDirtLevelScript;
    public ScriptMovePane sign;

	void OnMouseDown()
    {
        
        Renderer rend = this.GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.yellow);
    /*    lowestDirtLevelScript = GameObject.Find("Unit 1 Level 3").GetComponent<ScriptMovePane>();

        // Debug.Log("About to start startMovement() method in ScriptMovePane...");
        if(sign.signWasSelected == true)
        {
            if(lowestDirtLevelScript.isUpAllWay == false)
            {
                lowestDirtLevelScript.startMovementUp();
                selected = true;
            }
            else if(lowestDirtLevelScript.isUpAllWay == true)
            {
                lowestDirtLevelScript.startMovementDown();
                selected = false;
            }
            sign.signWasSelected = false;
        }
        
        */
        
        //Debug.Log("startMovement() Method succesfully finished.");
    }

    private void OnMouseUpAsButton()
    {
        Renderer rend = this.GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.clear);
        

        
        
    }
}
