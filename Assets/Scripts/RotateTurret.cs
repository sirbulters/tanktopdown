using UnityEngine;
using System.Collections;

public class RotateTurret : BaseRotateTurret {

	//iets naar baseclass

	public Camera camera;


	// Use this for initialization
	//void Start () {
		//iets naar baseclass

	//}
	
	// Update is called once per frame
	override protected void Update () {
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = camera.transform.position.y - Turret.transform.position.y;


		Vector3 worldPos = camera.ScreenToWorldPoint(mousePos);

		targetPos = worldPos;
		base.Update ();


		//iets naar baseclass




		//print("worldPos" + worldPos);

	}
}
