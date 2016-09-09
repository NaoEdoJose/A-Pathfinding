using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public LayerMask unwalkableMask;
	public Vector2 gridWorldSize;
	public float nodeRadius;
	Node[,] grid;

	float nodeDiameter;
	[Range(4,32)]
	int gridSizeX;
	[Range(4,32)]
	int gridSizeY;


	void Start(){
		nodeDiameter = nodeRadius * 2;
		CreateGrid ();
	}

	void CreateGrid(){
		grid = new Node[ gridSizeX, gridSizeY];
		Vector3 worldBottomLeft = transform.position - Vector3.right * gridWorldSize.x / 2 - Vector3.forward * gridWorldSize.y / 2;
	
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube (transform.position, new Vector3 (gridWorldSize.x,1,gridWorldSize.y));
	
	}


}