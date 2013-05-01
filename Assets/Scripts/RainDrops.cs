using UnityEngine;
using System.Collections;

public class RainDrops : MonoBehaviour {
    public int maxRainDrops = 10;
    public GameObject rainDrop;
    static int currentRainDrops;
    static int score;
    static int missed;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScoreText();
        for (int i = 0; i < maxRainDrops; i++)
        {
            Vector3 rainDropPosition = new Vector3(transform.position.x + Random.Range(-250, 250), transform.position.y + Random.Range(20, 75), transform.position.z + Random.Range(-250, 250));
            Instantiate(rainDrop, rainDropPosition, new Quaternion());
        }
        currentRainDrops = maxRainDrops;
	}

    private static void UpdateScoreText()
    {
        GameObject.Find("ScoreText").guiText.text = "Score: " + score;
    }

    private static void UpdateMissedText()
    {
        GameObject.Find("MissedText").guiText.text = "Missed: " + missed;
    }
	
	// Update is called once per frame
	void Update () {
        Screen.lockCursor = true;
        while (currentRainDrops < maxRainDrops)
        {
            Vector3 rainDropPosition = new Vector3(transform.position.x + Random.Range(-250, 250), transform.position.y + Random.Range(20, 75), transform.position.z + Random.Range(-250, 250));
            Instantiate(rainDrop, rainDropPosition, new Quaternion());
            currentRainDrops++;
        }
	}

    public static void HitBullet()
    {
        currentRainDrops--;
        score++;
        UpdateScoreText();
    }

    internal static void HitGround()
    {
        currentRainDrops--;
        missed++;
        UpdateMissedText();
    }


}
