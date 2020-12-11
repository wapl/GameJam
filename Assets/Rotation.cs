using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
	[SerializeField] private GameObject pivot,player;
	private float time,rotation,wait;
	[SerializeField] private float speed,curRotation,limti;
	// Use this for initialization
	void Start () {
		Random.seed=(int)System.DateTime.Now.Ticks;
		wait=0f;
	}
	
	// Update is called once per frame
	void Update () {
		time=time+Time.deltaTime;
		
		//Debug.Log(time);
		if(time>=4)
		{
			
			
			float choice=Random.Range(0,100);
			if(curRotation==0.0f)
			{
				if(choice==50)
				{
					Debug.Log(pivot.transform.rotation.z);
					/*while(pivot.transform.rotation.z==90f)
					{
						Debug.Log("Hello");
						Debug.Log(pivot.transform.rotation.z);
						pivot.transform.Rotate(0,0,speed*Time.deltaTime);
					}*/
					pivot.transform.rotation=Quaternion.Slerp(pivot.transform.rotation,Quaternion.Euler(0,0,90f),time);
					curRotation=90f;
				}
				else 
				{
					
					pivot.transform.rotation=Quaternion.Slerp(pivot.transform.rotation, Quaternion.Euler(0, 0, 270),time);
					curRotation=270f;
				}
			}
			else if (curRotation==90.0f)
			{
				if(choice<=20)
				{
					
					pivot.transform.rotation=Quaternion.Slerp(pivot.transform.rotation, Quaternion.Euler(0, 0, 0),time*speed);
					curRotation=0f;
				}
				else 
				{
					
					
					pivot.transform.rotation=Quaternion.Slerp(pivot.transform.rotation, Quaternion.Euler(0, 0, 180),time*speed);
					
					curRotation=180f;
					player.transform.Rotate(0,0,curRotation);
				}
			}
			else if (curRotation==180f)
			{
				if(choice<=20)
				{
					
					pivot.transform.rotation=Quaternion.Slerp(pivot.transform.rotation, Quaternion.Euler(0, 0, 90),time*speed);
					curRotation=90f;
				}
				else 
				{
					
					pivot.transform.rotation=Quaternion.Slerp(pivot.transform.rotation, Quaternion.Euler(0, 0, 270),time*speed);
					curRotation=270f;
				}
			}
			else if(curRotation==270f)
			{
				if(choice<=20)
				{
						
					pivot.transform.rotation=Quaternion.Slerp(pivot.transform.rotation, Quaternion.Euler(0, 0, 180),time*speed);
					curRotation=180f;
					player.transform.Rotate(0,0,curRotation);
				}
				else 
				{
					
					pivot.transform.rotation=Quaternion.Slerp(pivot.transform.rotation, Quaternion.Euler(0, 0, 270),time*speed);
					curRotation=0f;
				}
			}
			//player.SetActive(false);
			//player.transform.GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Kinematic;
			wait=0.0f;
			
			
			//Debug.Log(player.GetComponent<Rigidbody2D>().bodyType);
			wait=0.0f;
			time=0.0f;
			while(wait<limti)
			{
				//Debug.Log("waiting");
				wait=Time.deltaTime+wait;
			}
			
			//player.GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Dynamic;
			

		}
		
			
		
	}

	
}
