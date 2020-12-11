using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Boolean grounded,onAir,collison,movedLeft;
	private Rigidbody2D rigidbody,legRigid;
	private Transform transform;
	[SerializeField]private float xMovement,yMovement,verMovement;
	//[SerializeField] private float max_speed;
	[SerializeField]private float speed;
	[SerializeField] private float jumpheight;
	//[SerializeField] GameObject legs;
	Vector2 velocity;
	[SerializeField] private GameObject gameObject,pivot;
	[SerializeField]private Boolean hasJumped;
	[SerializeField]private Transform player;
	[SerializeField] private float curRotation;
	[SerializeField] private GameManger gameManger;
	
	void OnCollisionEnter2D(Collision2D other){
		
		//if (other.gameObject.CompareTag("Platform") ){
			
				grounded = true;
				
			
			
		//}
	}
/*void OnCollisionExit(Collision2D other){
		if(other.gameObject.CompareTag("Platform")){
			grounded = false;
		}
	}*/


	// Use this for initialization
	void Start () {
		grounded=true;
		movedLeft=false;
		rigidbody=gameObject.GetComponent<Rigidbody2D>();
		player=gameObject.GetComponent<Transform>();
		
		//legRigid=this.gameObject.GetComponent<Rigidbody2D>();
		//transform=this.gameObject.GetComponent<Transform>();
		//speed = 10;
		//jumpheight=20;
	}
	
	// Update is called once per frame
	void Update () {
		//float x_movement=Input.GetAxis("Horizontal");
		
		//transform.Translate(x_movement*Time.deltaTime*speed,0,0);
		hasJumped=Input.GetButtonDown("Jump");
		if((Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.LeftArrow) ) && !movedLeft )
		{
			
			
			player.RotateAround(player.position,player.up,-180f);
			movedLeft=true;
		}
		else if(movedLeft && (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) ) )
		{
			
			player.RotateAround(player.position,player.up,180f);
			movedLeft=false;
		}

	}
	void FixedUpdate()
	{
		xMovement = Input.GetAxis("Horizontal");
		verMovement=Input.GetAxis("Vertical");
		yMovement=Input.GetAxis("Jump");
		
		Vector2 move = new Vector2 (xMovement,0);
		Vector2 jump=new Vector2(0,yMovement);
		//Debug.Log(movedLeft);
		//legRigid.velocity=move*speed;
		
		//Debug.Log(xMovement);
		rigidbody.velocity = move*speed;
	
		//rigidbody.AddForce(move*speed);
		//rigidbody.AddForce(move*speed);
		if (yMovement==1 && grounded){
			rigidbody.AddForce(jump*jumpheight);
			grounded=false;
		}

		
		
		
		//Debug.Log(grounded);
	}
}
