using UnityEngine;
using System.Collections;

public class BaseRotateTurret : MonoBehaviour {

	private Transform[] transforms; //naar baseclass
	protected Transform Turret; //naarbaseclass
	protected Transform Nozzle;
	protected Vector3 targetPos;

	// Use this for initialization
	protected virtual void Start () {
	
		bool TurretFound = false;

		//naar baseclass
		transforms = gameObject.GetComponentsInChildren<Transform> ();
		foreach(Transform t in transforms)
		{
			if (t.gameObject.name == "Turret")
			{
				Turret = t;
				TurretFound = true;
			}
			if (t.gameObject.name == "Nozzle")
			{
				Nozzle = t;
			}
		}

		if (!TurretFound) 
		{
			print ("no Turret was found in the gameobject");
		}

	}
	
	// Update is called once per frame
	protected virtual void Update () {
	
		//naar baseclass
		Turret.LookAt ( targetPos );

	}
}
