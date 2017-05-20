using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballStart : MonoBehaviour {
    public float speed = 30;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	

}
