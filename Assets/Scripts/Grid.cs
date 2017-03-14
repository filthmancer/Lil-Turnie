using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
	public IntVector Size;
	public Tile [,] Tiles;
	private float tilespacing = 1.2F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool Vacant(IntVector p)
	{
		return Tiles[p.x,p.y].IsVacant;
	}

	public void Init(IntVector i)
	{
		Tiles = new Tile[i.x, i.y];
		for(int x = 0; x < i.x; x++)
		{
			for(int y= 0; y < i.y; y++)
			{
				Tiles[x,y] = GameManager.instance.Prefabs.GetObject("TileObject").GetComponent<Tile>();
				Tiles[x,y].transform.SetParent(this.transform);
				Tiles[x,y].GetComponent<Renderer>().material.color = Random.value > 0.5F ? Color.green : Color.black;
				Tiles[x,y].transform.localPosition = new Vector3(x * tilespacing, 0.0F, y * tilespacing);
			}
		}
	}

	public Step [] StepsToFrom(IntVector a, IntVector b)
	{
		List<Step> final = new List<Step>();
		IntVector vel = IntVector.Subtract(b, a);
		IntVector velsign = new IntVector((int)Mathf.Sign(vel.x), (int)Mathf.Sign(vel.y));
		int currx = a.x, curry = a.y;
		for(int x = 0; x < Mathf.Abs(vel.x); x++)
		{
			currx = a.x + velsign.x;
			final.Add(new Step(Tiles[currx, curry]));
		}

		for(int y = 0; y < Mathf.Abs(vel.y); y++)
		{
			curry = a.y + velsign.y;
			final.Add(new Step(Tiles[currx, curry]));
		}
		return final.ToArray();
	}
}