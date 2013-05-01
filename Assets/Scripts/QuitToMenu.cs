using UnityEngine;
using System.Collections;

public class QuitToMenu : MonoBehaviour {
	void OnGUI() {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}
	}
}
