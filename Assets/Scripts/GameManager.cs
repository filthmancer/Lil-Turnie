using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityPooler;

public class GameManager : MonoBehaviour {
	public GOContainer Prefabs;
	public static GameManager instance;
	public Room _Room;
	public Grid _Grid{get{return _Room._Grid;}}
	void Awake() {instance = this;}
	// Use this for initialization
	void Start () {
		GenerateRoom();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	Room GenerateRoom()
	{
		Room r = Prefabs.GetObject("RoomObject").GetComponent<Room>();
		r.Init(new IntVector(5,5));
		r.transform.SetParent(this.transform);
		return r;
	}

	public IEnumerator MoveUnit(Unit u, Step [] steps)
	{
		for(int i = 0; i < steps.Length; i++)
		{
			
			
		}
		yield return null;
	}
}

[System.Serializable]
public class GOContainer
{
	public GOPool [] Objects;
	public GameObject GetObject(string n)
	{
		for(int i = 0; i < Objects.Length; i++)
		{
			if(Objects[i].Name == n) return Objects[i].Get();
		}
		return null;
	}

	public void Init()
	{
		for(int i = 0; i < Objects.Length; i++)
		{
			Objects[i].Obj.PopulatePool(Objects[i].Initial);
		}
	}
}

[System.Serializable]
public class GOPool
{
	public string Name;
	public GameObject Obj;
	public int Initial = 1;
	public GameObject Get(){return Obj.Get();}
}
