using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	IEnumerator NextLevel() {
		float fadeTime = GameObject.Find ("_GM").GetComponent<SceneFading>().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
