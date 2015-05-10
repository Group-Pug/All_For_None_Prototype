using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	void NextLevel() {
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
