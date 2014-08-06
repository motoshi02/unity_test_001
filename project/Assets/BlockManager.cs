using UnityEngine;
using System.Collections;

public class BlockManager : MonoBehaviour {
	public GameObject BlockPrefab;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; ++i) {
			for (int j = 0; j < 12; ++j) {
				Instantiate(this.BlockPrefab, new Vector3(i * 3.2f - 8, 0, 28.5f - 1.2f * j), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
