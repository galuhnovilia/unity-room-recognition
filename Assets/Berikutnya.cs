using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berikutnya : MonoBehaviour {

	public void MENU_ACTION_GotoPage(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}
}
