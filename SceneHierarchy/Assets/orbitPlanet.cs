using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitPlanet : MonoBehaviour {

    private GameObject parentPlanet;
    public int speed;

	// Use this for initialization
	void Start () {
        parentPlanet = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(parentPlanet.transform.position, new Vector3(0, 0, 1), speed * Time.deltaTime);
	}
}
