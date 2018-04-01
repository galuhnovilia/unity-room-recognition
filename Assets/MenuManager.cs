using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	public Menu CurrentMenu;
	public void Start () {
		ShowMenu (CurrentMenu);
	}

	public void ShowMenu(Menu menu)	{
		if (CurrentMenu != null)
			CurrentMenu.ISOpen = false;

		CurrentMenu = menu;
		CurrentMenu.ISOpen = true;
	} 
}
