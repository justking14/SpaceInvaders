using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitchAlter : MonoBehaviour {
    AudioSource m_MyAudioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		m_MyAudioSource = GetComponent<AudioSource>();
		m_MyAudioSource.pitch = transform.position.z;
	}
}
