using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    public int movementSpeed = 1;
    public int rotationSpeed = 1;
    public float scalingSpeed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    int getMovementSpeed()
    {
        return movementSpeed;
    }
}
