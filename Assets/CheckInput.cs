using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    void Update()
    {
        float translation = UnityEngine.Input.GetAxis("VerticalP2") * speed;
        float rotation = UnityEngine.Input.GetAxis("HorizontalP2") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}
