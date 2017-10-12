using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_using_02_2 : MonoBehaviour
{

    //기존 화면으로 돌아가게 해주는 버튼
    public void on_BackButton_Click()
    {
        SceneManager.LoadScene("01_MainTab");
    }
}
