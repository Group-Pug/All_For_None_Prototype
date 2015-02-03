using UnityEngine;
using System.Collections;

public class MainMenuHandler : MonoBehaviour {

	public void ExitGame() {
		//Add confirmation popup
		Application.Quit();
	}

	public void StartGame() {
		Application.LoadLevel(3);
	}
}
