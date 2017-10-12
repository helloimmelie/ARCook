using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_using_04_0 : MonoBehaviour {

    public void onClick_Start()
    {
        SceneManager.LoadScene("Scene0");
    }
    public void onClick_Start_2()
    {
        SceneManager.LoadScene("DEMO_Scene00");
    }

    public void on_BackButton_Click()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android) //뒤로 가기
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
