using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuideButton : MonoBehaviour
{

    private int S_Num;

    private void Start()
    {
        //S_Num = EditorSceneManager.GetActiveScene().buildIndex;
        S_Num = SceneManager.GetActiveScene().buildIndex;
    }

    public void onClick_Back()
    {
        Debug.Log("Press Back");
        S_Num = S_Num - 1;

        SceneManager.LoadScene(S_Num);

    }

    public void onClick_Next()
    {
        Debug.Log("Press Next");
        S_Num = S_Num + 1;

        SceneManager.LoadScene(S_Num);

    }

}