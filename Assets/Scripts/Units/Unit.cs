using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
	public int Movement = 1;
	public int Attack = 1;
	public int Health = 1;

	public Tile Position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void Detach()
	{
		Position.Detach();
		Position = null;
	}

	public void Attach(Tile t)
	{
		Position = t;
		Position.Attach(this);
	}

	public void MoveTo(IntVector pos)
	{

	}
}

public class Step
{
	public Tile Position;
	public Step(Tile t)
	{
		Position = t;
	}
}
