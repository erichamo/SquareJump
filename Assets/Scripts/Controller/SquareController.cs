using UnityEngine;
using System.Collections;

public class SquareController : MonoBehaviour {
	
	//public Animator squareRotate;
	public float speed = 8;
	public float jump = 15;
	public bool doubleJump;
	public bool isGround;

	void Start()
	{
		this.isGround = false;
		this.doubleJump = false;
	}

	void FixedUpdate()
	{
		/*this.transform.position = new Vector3(this.transform.localPosition.x+this.speed/50,
	    	   	                              this.transform.localPosition.y,
	       		                              this.transform.localPosition.z);*/
		this.transform.position += this.transform.right * this.speed * Time.deltaTime;
	}

	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			if(this.isGround)
			{
				this.GetComponent<Rigidbody2D>().AddForce(this.transform.up * this.jump * 50);
				this.isGround = false;
				this.doubleJump = true;
			}
			else if(this.doubleJump)
			{
				this.GetComponent<Rigidbody2D>().AddForce(this.transform.up * this.jump * 50);
				this.doubleJump = false;
			}
		}
		/*if(!this.isGround)
		{
			this.squareRotate.SetBool("Go",true);
		}
		else
		{
			this.squareRotate.SetBool("Go",false);
		}*/
	}

	void OnCollisionEnter2D(Collision2D colision)
	{
		this.isGround = colision.gameObject.tag == "ground";

		if(colision.gameObject.tag == "ground")
		{
			this.doubleJump = false;
		}
	}
}
