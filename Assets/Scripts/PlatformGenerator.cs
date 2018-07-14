using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var playerX = Player.transform.position.x;
	    var platformX = transform.transform.position.x;
        

        if(playerX<platformX)
            transform.position = new Vector3(platformX-120,0,0);

	}
}
