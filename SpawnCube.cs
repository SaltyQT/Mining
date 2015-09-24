using UnityEngine;
using System.Collections;

public class SpawnCube : MonoBehaviour {

	public GameObject Cube;
	bool cubeSpawned = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timeToSpawnCube()) {
			SpawnTheCube();
		}
	}

	void SpawnTheCube() {
		Vector3 cubePosition = new Vector3(0.0f, 0.0f, 0.0f);
		Instantiate (Cube, cubePosition, Quaternion.identity);
		cubeSpawned = true;
	}

	bool timeToSpawnCube(){
		if (Time.time >= 3.0f &&! cubeSpawned) {
			return true;
		} else {
			return false;
		}
	}

}
