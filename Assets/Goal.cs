using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	[SerializeField] GameManger gameManger;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("HElp");
		if(other.gameObject.CompareTag("Player"))
		{
			Debug.Log("It oover ");
			gameManger.Win();
		}
	}
}
