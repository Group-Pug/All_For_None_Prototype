using UnityEngine;
using System.Collections;

public class MenuHandler : MonoBehaviour {
	
	public void StartGame() {
		Application.LoadLevel(4);
	}

	public void ExitGame() {
		//Add confirmation popup
		Application.Quit();
	}
}
