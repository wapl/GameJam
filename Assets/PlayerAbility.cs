using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerAbility : MonoBehaviour {

	[SerializeField] private Tilemap level;
	public GameObject temp;
	
	[SerializeField] private bool hasCollided,colidedPlayerBlock;
	[SerializeField] private GameObject block,grid,parent;
	
	// Use this for initialization
	  void OnTriggerEnter2D(Collider2D col)
	 {
		 
		 	if( col.CompareTag("Platform"))
			 {
				 hasCollided=true;

				 
			 }
			 else if(col.CompareTag("PlayerBlock"))
			 {
				 Debug.Log("ColidedPlayer");
				 colidedPlayerBlock=true;
				 hasCollided=false;
				 
				
				 block=col.gameObject;
			 }
			 
	 }
	 void OnTriggerExit2D(Collider2D other)
	 {
		if(other.gameObject.CompareTag("Platform"))
		{
			hasCollided=false;
		}
		else if (other.CompareTag("PlayerBlock"))
		{
			colidedPlayerBlock=false;
		}

	}
	void Start () {
		hasCollided=false;
		colidedPlayerBlock=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(hasCollided);
		if(Input.GetButtonDown("Fire1")  && !hasCollided )
		{
			Debug.Log(colidedPlayerBlock);
			if( !hasCollided && !colidedPlayerBlock)
			{
				
				temp= Object.Instantiate(block.gameObject,this.transform.position,this.transform.rotation,parent.transform);
				//temp.transform.localScale=this.transform.localScale;
				
				temp.transform.SetParent(grid.transform);
				temp.GetComponent<SpriteRenderer>().enabled=true;
				
			}
			else if(colidedPlayerBlock)
			{
				colidedPlayerBlock=false;
				Debug.Log("Destroyed");
				 temp=Object.Instantiate(block,this.transform.position,this.transform.rotation,grid.transform);
				 temp.GetComponent<SpriteRenderer>().enabled=false;
				Destroy(block);
				
				block=temp;
			}
			

			
			

				
		}
		
	}
}
