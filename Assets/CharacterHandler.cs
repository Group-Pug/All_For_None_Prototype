using UnityEngine;
using System.Collections;

public class CharacterHandler : MonoBehaviour {
	private GameObject model;
	[SerializeField] private float rotationSpeed = 50f;

	// Update is called once per frame
	void Update () {
		if(model != null){
			RotateCharacter ();
		}else{
			model = GameObject.FindGameObjectWithTag ("Character");
		}
	}
	void RotateCharacter() {
		model.transform.localEulerAngles += new Vector3(0, Time.deltaTime * rotationSpeed, 0);
	}
}
