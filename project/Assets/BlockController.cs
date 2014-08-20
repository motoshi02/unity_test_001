using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// do nothing
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z - 0.05f);
	}
	
	// 衝突時
	void OnCollisionEnter (Collision col) {
		Destroy(this.gameObject);
	}
}
