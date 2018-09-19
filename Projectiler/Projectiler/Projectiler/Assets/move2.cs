using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour {
    public GameObject bulletPrefab;
	public AudioClip shootSound;
	private AudioSource source;
	private float lowPitchRange = .75F;
	private float highPitchRange = 1.25F;
    //public Transform bulletSpawn;
	// Use this for initialization
	void Start () {
				source = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		   var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

       // transform.Rotate(0, x, 0);
        transform.Translate(-x/10.0f, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space)){
            Fire();
        }
	}
void Fire()
{
		source.pitch = Random.Range (lowPitchRange, highPitchRange);
		source.PlayOneShot (shootSound, 1F);

    var bulletSpawn = new GameObject().transform;
    bulletSpawn.position = new Vector3(transform.position.x, transform.position.y,transform.position.z - 1);
    // Create the Bullet from the Bullet Prefab
    var bullet = (GameObject)Instantiate (
        bulletPrefab,
        bulletSpawn.position,
        bulletSpawn.rotation);

    // Add velocity to the bullet
    bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

    // Destroy the bullet after 2 seconds
    Destroy(bullet, 2.0f);
}

}
