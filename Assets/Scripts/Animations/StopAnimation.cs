using UnityEngine;
using System.Collections;

public class StopAnimation : MonoBehaviour {

	void StopCurrentAnimation() 
	{
		GetComponent<Animator>().enabled = false;
	}
}
