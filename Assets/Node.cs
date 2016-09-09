using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	public bool walkable;
	public Vector3 worldPosition;

	public Node( bool _walkable , Vector3 _worldPosition){
		_walkable = walkable;
		_worldPosition = worldPosition;
	}
}
