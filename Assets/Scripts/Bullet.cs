using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour {

	public GameObject Bullet_prefab;
	public GameObject Granade_prefab;
	public float Bulletimpulse;
	public float Granadeimpulse;



	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) 
		{
			Camera cam = Camera.main;
			GameObject thebullet = (GameObject)Instantiate (Bullet_prefab, cam.transform.position, cam.transform.rotation);
			thebullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * Bulletimpulse, ForceMode.Impulse);

			Object.Destroy(thebullet, 20.0f);
		}

		if (Input.GetButtonDown ("Fire2")) 
		{
			Camera cam = Camera.main;
			GameObject Granade = (GameObject)Instantiate (Granade_prefab, cam.transform.position, cam.transform.rotation);
			Granade.GetComponent<Rigidbody>().AddForce(cam.transform.forward * Granadeimpulse, ForceMode.Impulse);


		}




		}
	}

