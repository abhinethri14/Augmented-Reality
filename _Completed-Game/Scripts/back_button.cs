using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using test;


public class back_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void back_action()
    {
        if (login.value == 0)
            UnityEngine.SceneManagement.SceneManager.LoadScene("Roll-a-ball");
        else
            UnityEngine.SceneManagement.SceneManager.LoadScene("Roll-a-ball-cube");
    }
}
