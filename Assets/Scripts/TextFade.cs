using UnityEngine;
using System.Collections;

public class TextFade : MonoBehaviour {
    public float textFadeTime = 4f;

	void Start () {
        Destroy(gameObject, textFadeTime);
	}
}
