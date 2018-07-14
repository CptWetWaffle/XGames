using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{

    public static int Score = 0;

    public static Text ScoreText ;
    public static int Lives = 5;

    private const string LiveString="health";
	// Use this for initialization
	void Start ()
	{
	    ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void UpdateScore(int scoreToAdd)
    {

        Score += scoreToAdd;
        Debug.Log("Score " + Score);

        ScoreText.text = Score.ToString();
    }

    public static void LooseLife()
    {
        var go = GameObject.Find("health" + Lives);
        Lives--;
        Debug.Log("Vidas " + Lives );
        GameObject.Find("Character").transform.position = new Vector3(-3.94f, -0.11f,0);
        GameObject.Find("Plane1").transform.position = new Vector3(-30.4f,0,0);
        GameObject.Find("Plane2").transform.position = new Vector3(-82.3f, 0,0);
        GameObject.Find("Plane3").transform.position = new Vector3(-132.3f, 0,0);

        Destroy(go);
        if (Lives<=0)
        {
            Lives = 5;
            Score = 0;
            SceneManager.LoadScene("EndlessRunner");

        }
    }



}
