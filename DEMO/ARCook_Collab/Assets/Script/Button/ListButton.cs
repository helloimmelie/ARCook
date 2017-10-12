using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;



public class ListButton : MonoBehaviour
{

    public Button button; //버튼
    public Text text; //레시피 제목
    public Image image; //이미지
    public string id;
    public static string tmpid;

    public GameObject respawnPrefab;
    public GameObject respawn = GameObject.FindWithTag("ListView");
    void Awake()
    {
        DontDestroyOnLoad(this);
        Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);
    }

    public void onClick_List()
    {
        Debug.Log(id + "called");
        SceneManager.LoadScene("04_0_Cooking_preparation_2");
    }
    public void onClick_Back()
    {
        SceneManager.LoadScene("01_MainTab");
    }


}

