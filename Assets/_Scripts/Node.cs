using UnityEngine;
using System.Collections;

public class Node {

	public string state;
	public Vector3 worldPosition;

	public int gCost;
	public int hCost;

	public int gridX;
	public int gridY;
	public bool walkable;

	public Node parent;

	public Node(string _state, Vector3 _worldPos , int _gridX, int _gridY) {

		state = _state;
		worldPosition = _worldPos;
		gridX = _gridX;
		gridY = _gridY;
		switch (state) {
		case "walkable":
			walkable = true;
			return;
		}
			
	}

	public int fCost{
		get{ 
			return gCost + hCost;
		}
	}
}
