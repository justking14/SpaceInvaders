using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeP : MonoBehaviour {
	public GameObject flashPrefab;
	float timeDelay = 5;
	
	void Start(){
        Invoke("LaunchProjectile", 5);
	}
	void LaunchProjectile(){
        GameObject instance = Instantiate(flashPrefab);
		//Vector3 newP = new Vector3(15.0f, 5.0f, -21.0f);
		//instance.transform = newP;
		Invoke("LaunchProjectile", 3);

    }
	void Update () {
		
	}
}
