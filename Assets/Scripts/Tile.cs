using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public IntVector Point;
	public int x {get{return Point.x;}}
	public int y {get{return Point.y;}}
	public Unit _Unit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool IsVacant{
		get{
			return _Unit != null;
		}
		set{
			if(!value) Detach();
		}
		
	}

	public void Detach()
	{
		_Unit = null;
	}
	public void Attach(Unit u)
	{
		_Unit = u;
	}
}
