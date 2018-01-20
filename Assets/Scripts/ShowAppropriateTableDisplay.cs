using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAppropriateTableDisplay : MonoBehaviour {
    public GameObject table;
    public Renderer dataTable;
    public Shader newShader;

    void OnMouseDown()
    {
        //table.SetActive(true);
        dataTable.material.shader = newShader;
        Debug.Log("in ShowAppropriateTableDisplay class. Just displayed right data image. ");
    }
}
