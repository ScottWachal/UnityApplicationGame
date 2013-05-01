using UnityEngine;
using System.Collections;

public class MenuObject : MonoBehaviour {
	public int option = 0;
	
	void OnMouseEnter() {
		renderer.material.color = Color.red;
	}
	
	void OnMouseExit() {
		renderer.material.color = Color.white;
	}
	
	void OnMouseDown() {
		if(option == 0)	
		{
			Application.Quit();	
		}
		else
		{
			Application.LoadLevel(option);	
		}
	}
}
