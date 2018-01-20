using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
    public float distanceForward;
    public float distanceUp;
    public float left;

    public GameObject leader;

	// Update is called once per frame
	void Update () {
        this.transform.position = leader.transform.position + leader.transform.forward * distanceForward + leader.transform.up * distanceUp + leader.transform.right * left;

    }
}
