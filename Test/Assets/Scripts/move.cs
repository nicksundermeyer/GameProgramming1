using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public float speed;

    private int counter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//        counter++;
//        Debug.Log(counter);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, speed), Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0, -speed), Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(speed, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-speed, 0), Space.World);
        }

        pointToMouse();
    }

    void pointToMouse()
    {

    }
}
