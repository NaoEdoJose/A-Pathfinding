using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour {

	void Update () {
		transform.position = new Vector3 (Mathf.RoundToInt(this.transform.position.x) + 0.5f,Mathf.RoundToInt(this.transform.position.y)+ 0.5f,Mathf.RoundToInt(this.transform.position.z)+ 0.5f);

	}
}
