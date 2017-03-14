using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {
	public Grid _Grid;
	public int _Lifetime = 0;

	
	void Start () {
		
	}
	
	void Update () {
		
	}

	public void Init(IntVector size)
	{
		GenerateGrid(size);
	}

	Grid GenerateGrid(IntVector size)
	{
		Grid g = GameManager.instance.Prefabs.GetObject("GridObject").GetComponent<Grid>();
		g.Init(size);
		g.transform.SetParent(this.transform);
		return g;
	}
}
