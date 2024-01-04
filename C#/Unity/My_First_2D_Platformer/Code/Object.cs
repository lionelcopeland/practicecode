//Unity First Platformer

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehavior
{
	public float speed = 3;
	public Rigidbody2D rb;
	public float jumpForce = 10;
	//Start is called before the first frame update
	void Start()
	{
		
	}
	
	//Update is called once per frame
	void update()
	{
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
	    if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.W))
		{
			rb.AddForce(Vector3.up * jumpForce);
		}
	}
}
