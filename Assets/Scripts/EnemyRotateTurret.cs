﻿using UnityEngine;
using System.Collections;

public class EnemyRotateTurret : BaseRotateTurret {
	public Transform player;



	//override protected void Start() 
	//{



	//	base.Start ();
	
	//}
	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	override protected void Update () {

		if (player != null) {

			targetPos = player.position + Vector3.up * 1.31f;
			base.Update ();

		}
	}
}
