using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_cooking_food_for_oneself : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick_oneselfButton()
    {
        SceneManager.LoadScene("03_1_Theme_List_oneself");      //자취요리로 들어가는 버튼
    }
}
