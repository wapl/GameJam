using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {
	[SerializeField] GameManger gameManger;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		//Debug.Log("It over Anaking i have the hight groun");
		if(other.gameObject.CompareTag("Player"))
		{
			//Debug.Log("You Underestimate my clutch ablities ");
			//Debug.Log("Do not Try it ");
			gameManger.Lose();
		}
	}
}
