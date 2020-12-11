using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour {

	[SerializeField] private GameObject win;
	[SerializeField] private GameObject lose;
	[SerializeField] private GameObject player,legs;
	bool hasWon,hasLost;

	// Use this for initialization
	void Start () {
		hasWon=false;
		hasLost=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Win()
	{
		if(!hasWon && !hasLost)
		{
			win.SetActive(true);
			hasWon=true;
		}
		
	}
	public void Lose()
	{
		if(!hasLost && !hasWon)
		{
			lose.SetActive(true);
			hasLost=true;
		}
		
	}

	public bool getWon()
	{
		return hasWon;
	}

	public bool getLost()
	{
		return hasLost;
	}

}
