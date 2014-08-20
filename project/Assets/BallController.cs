using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	// メンバ変数
	private float speed = 20.0f;

	// Use this for initialization
	void Start () {
		this.rigidbody.AddForce(
			this.transform.forward * this.speed,
			ForceMode.Impulse
		);
	}
	
	// Update is called once per frame
	void Update () {
		// do nothing
	}
	
	// 衝突時
	void OnCollisionEnter (Collision col) {
		Destroy(this.gameObject);
	}
}
