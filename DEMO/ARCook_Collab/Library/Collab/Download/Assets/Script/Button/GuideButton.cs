using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class GuideButton : MonoBehaviour {

    private int S_Num;

    private void Start()
    {
        S_Num = EditorSceneManager.GetActiveScene().buildIndex;
    }

    public void onClick_Back()
    {
        S_Num = S_Num - 1;

        EditorSceneManager.LoadScene(S_Num);

    }

    public void onClick_Next()
    {
        S_Num = S_Num + 1;

        EditorSceneManager.LoadScene(S_Num);

    }

}
