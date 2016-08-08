using UnityEngine;
using System.Collections;

public class SquareController : MonoBehaviour {
	
	//public Animator squareRotate;
	public float speed;
	public float jump;
	public bool isGround;
	public bool inMovement;
	public bool initGo;

	void Start()
	{
		this.isGround = false;
		this.inMovement = false;
		this.initGo = false;
	}

	void FixedUpdate()
	{
		/*this.transform.position = new Vector3(this.transform.localPosition.x+this.speed/50,
	    	   	                              this.transform.localPosition.y,
	       		                              this.transform.localPosition.z);*/
		this.transform.position += this.transform.right * speed * Time.deltaTime;
	}

	void Update()
	{
		if(this.isGround &&
		   Input.GetMouseButtonDown(0))
		{
			/*this.GetComponent<Rigidbody2D>().velocity = new Vector3(this.speed/50,
			                                                        this.jump, 0);*/
			this.GetComponent<Rigidbody2D>().AddForce(transform.up * this.jump * 50);
			this.isGround = false;
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
		isGround = colision.gameObject.tag == "ground";
	}
}
