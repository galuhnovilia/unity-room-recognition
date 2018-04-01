using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

	public void quit(){
		Debug.Log ("Application is Closed");
		Application.Quit ();
	}
}
