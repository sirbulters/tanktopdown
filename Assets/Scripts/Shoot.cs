using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject bulletPrefab;
	private GameObject Turret;
	private GameObject Nozzle;

	// Use this for initialization
	void Start () {
		Transform[] transforms = GetComponentsInChildren<Transform>();
		foreach(Transform t in transforms) 
		{
			if(t.gameObject.name == "Turret")
			{
				Turret = t.gameObject;
			}
			if(t.gameObject.name == "Nozzle")
			{
				Nozzle = t.gameObject;
			}
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Quaternion rotation = Quaternion.Euler(Vector3.up * Turret.transform.rotation.eulerAngles.y);

			Instantiate(bulletPrefab, Nozzle.transform.position, rotation);
		}
	}
}
