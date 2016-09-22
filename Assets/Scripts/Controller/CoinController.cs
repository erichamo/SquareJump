using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

	public Transform target;
	public bool bMoveTo;
	public float speed;

	void Start()
	{
		this.bMoveTo = false;
	}

	void Update()
	{
		if (this.bMoveTo)
		{
			float step = this.speed * Time.deltaTime;
			this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, step);
		}
	}

	void OnCollisionEnter2D(Collision2D colision)
	{
		if(colision.gameObject.tag == "player")
		{
			this.bMoveTo = true;
		}
		if(colision.gameObject.tag == "amount")
		{print("ENTRO");
			this.bMoveTo = false;
			Destroy(this);
		}
	}
}
