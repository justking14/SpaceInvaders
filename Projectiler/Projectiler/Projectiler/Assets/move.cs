using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	float stateIsGoingLeft =  1;
	float stateIsGoingRight = 0;
	float stateIsGoingDown = 0;
	float stateIsGoingDown2 = 0;

	float speedFactor = 50;
	public AudioClip stepSound;
	public AudioClip deathSound;

	private AudioSource source;
  void OnCollisionEnter (Collision col)
    {
		source.PlayOneShot (deathSound, 1F);

}
	float zAtTurn = 0;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
        InvokeRepeating("Update2", 0.0f, 1.0f);

	}

	// Update is called once per frame
	void Update2 () {
		source.PlayOneShot (stepSound, 1F);

		if(stateIsGoingLeft == 1){
						 print("a");

			transform.Translate(Vector3.right * Time.deltaTime * speedFactor);
			if(transform.position.x > 25){
				stateIsGoingLeft = 0;
				zAtTurn = transform.position.z;
				stateIsGoingDown = 1;
			}
		}
		 if(stateIsGoingDown == 1){
			transform.Translate(Vector3.forward * Time.deltaTime * speedFactor);
			if(Mathf.Abs(transform.position.z - zAtTurn) > 5){
				stateIsGoingDown = 0;
				stateIsGoingRight = 1;
			}
		}

		 if(stateIsGoingRight == 1){
			 print("C");
			transform.Translate(Vector3.right * Time.deltaTime * -1 * speedFactor);
			if(transform.position.x < 0){
				stateIsGoingRight = 0;
				zAtTurn = transform.position.z;
				stateIsGoingDown2 = 1;
			}
		}
		 if(stateIsGoingDown2 == 1){
			transform.Translate(Vector3.forward * Time.deltaTime * speedFactor);
			if(Mathf.Abs(transform.position.z - zAtTurn) > 5){
				stateIsGoingDown2 = 0;
				stateIsGoingLeft = 1;
			}
		}

	}
}
