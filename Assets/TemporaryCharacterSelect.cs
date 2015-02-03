using UnityEngine;
using System.Collections;

public class TemporaryCharacterSelect : MonoBehaviour {
	[SerializeField] private GameObject model;
	[SerializeField] private Vector3 spawnPos = new Vector3(5f,-3f,0f);

	public void SwitchModel () {
		if(GameObject.FindGameObjectWithTag ("Character") != null && GameObject.FindGameObjectWithTag ("Character").name == model.name){
			LoadGameScreen();
		}else{
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("Character"));
			GameObject newModel = GameObject.Instantiate (model, spawnPos, new Quaternion(0f,-180f,0f,0f)) as GameObject;
			newModel.name = model.name;
		}
	}

	void LoadGameScreen() {
		Application.LoadLevel(5);
	}
}
