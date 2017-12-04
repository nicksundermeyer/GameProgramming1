using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSprite : MonoBehaviour {

    public Vector3 initialPos;
    public Vector3 finalPos;

    GameObject obj;
    SceneManager sm;
    SpriteRenderer sr;

    private float step;
    private bool forwards = true;

	// Use this for initialization
	void Start () {
        transform.position = initialPos;
        obj = GameObject.Find("SceneManager");
        sm = obj.GetComponent<SceneManager>();
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        step = sm.movementSpeed * Time.deltaTime;

        // deciding whether to move forwards or backwards
        if (transform.position.Equals(initialPos))
            forwards = true;
        else if(transform.position.Equals(finalPos))
            forwards = false;

//        sr.color = Color.Lerp(Color.white, Color.black);

        // moving and scaling, changing color
        if (forwards)
        {
            transform.position = Vector2.MoveTowards(transform.position, finalPos, step);
            transform.localScale += new Vector3(sm.scalingSpeed, sm.scalingSpeed, 0);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, initialPos, step);
            transform.localScale -= new Vector3(sm.scalingSpeed, sm.scalingSpeed, 0);
        }

        // rotating
        transform.Rotate(new Vector3(0, 0, sm.rotationSpeed));
	}
}
