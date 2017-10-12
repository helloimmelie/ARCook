using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_using_02_1 : MonoBehaviour {

    public void on_oneselfButton_Click()
    {
        SceneManager.LoadScene("03_1_Theme_List_oneself");
    }

    public void on_BackButton_Click()
    {
        SceneManager.LoadScene("01_MainTab");
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

}
