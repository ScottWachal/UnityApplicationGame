using UnityEngine;
using System.Collections;

public class DelegateMenu	 : MonoBehaviour {
	private delegate void MenuDelegate();
	private MenuDelegate menuFunction;
	
	private float screenHeight;
	private float screenWidth;
	private float menuOptionHeight;
	private float menuOptionWeidth;
	
	void Start() {
		screenHeight = Screen.height;
		screenWidth = Screen.width;
		menuOptionHeight = screenHeight * 0.3f;
		menuOptionWeidth = screenWidth * 0.4f;
		
		menuFunction = anyKey;
	}
	
	void OnGUI() {
		menuFunction();	
	}
	
	void anyKey() {
		if(Input.anyKey)	
		{
			menuFunction = mainMenu;	
		}
		GUI.skin.label.alignment = TextAnchor.MiddleCenter;
		
		GUI.Label(new Rect(screenWidth * 0.45f, screenHeight * 0.45f, screenWidth *  0.1f, screenHeight * 0.1f),"Press Any Key To Continue...");	
	}
	
	void mainMenu(){
		if(GUI.Button(new Rect((screenWidth - screenHeight) * 0.5f, screenHeight * 0.1f, menuOptionWeidth, menuOptionHeight), "Start Game"))
		{
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect((screenWidth - screenHeight) * 0.5f, screenHeight * 0.5f, menuOptionWeidth, menuOptionHeight), "End Game"))
		{
			Application.Quit();
		}
	}
}
