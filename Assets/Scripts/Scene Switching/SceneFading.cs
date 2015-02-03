using UnityEngine;
using System.Collections;

public class SceneFading : MonoBehaviour {
	[SerializeField] private Texture2D fadeOutTexture; 	// overlay texture
	[SerializeField] private float fadeSpeed = 0.8f; 	// fade speed

	private int drawDepth = -1000; 						// order in draw hierarchy, lower is on top
	private float alpha = 1.0f; 						// texture alpha value between 0 and 1
	private int fadeDir = -1; 							// direction to fade: in = -1, out = 1;

	void OnGui() {
		// fade the alpha
		alpha += fadeDir * fadeSpeed * Time.deltaTime; 
		// clamp number between 0 and 1 because Gui.color is between 0 and 1
		alpha = Mathf.Clamp01 (alpha);

		//set color of GUI texture
		GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth; //render it on top
		GUI.DrawTexture ( new Rect (0,0,Screen.width, Screen.height), fadeOutTexture ); //fill screen
	}

	public float BeginFade( int direction ) {
		fadeDir = direction;
		return(fadeSpeed); // returning fade speed so we can time when to load next scene
	
	}

	//load level = fade in
	void OnLevelWasLoaded() {
		BeginFade (-1);
	}
}
