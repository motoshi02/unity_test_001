using UnityEngine;
using System.Collections;

public class RacketController : MonoBehaviour {
	// メンバ変数
	public GameObject BallPrefab;
	private float accel = 1000.0f;
	
	// Use this for initialization
	void Start () {
		// do nothing
	}
	
	// Update is called once per frame
	void Update () {
		this.rigidbody.AddForce(
			this.transform.right * Input.GetAxisRaw( "Horizontal" ) * this.accel,
			ForceMode.Impulse
		);
		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate(
				this.BallPrefab,
				new Vector3(this.transform.position.x, 0, this.transform.position.z + 1.2f),
				Quaternion.identity
			);
		}
	}
	
	// 衝突時
	void OnCollisionEnter (Collision col) {
		Debug.Log("TODO -- GameOver --");
	}
}
