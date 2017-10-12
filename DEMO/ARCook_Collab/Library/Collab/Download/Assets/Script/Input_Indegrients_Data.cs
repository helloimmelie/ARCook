using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SimpleJSON;

public class Input_Indegrients_Data : MonoBehaviour
{


    //입력된 재료명을 저장할 변수
    public string Indegrient_name;
    public static ArrayList itemListforIndegrient = new ArrayList();
    public Transform contentPanel;
    public GameObject listButton;

    private string outputUrl = "http://52.79.181.122:8080/ARCook_new/indegrients.jsp?indegrients=";
    private string tmp;
    //public Text outputtext;

    void Start()
    {

        var input = gameObject.GetComponent<InputField>();  //input필드를 찾아줄 변수
        var se = new InputField.SubmitEvent();              //이벤트
        se.AddListener(SubmitName);
        input.onEndEdit = se;

    }

    private void SubmitName(string arg0)
    {

        Indegrient_name = arg0;
        Debug.Log("Name:" + Indegrient_name);
        StartCoroutine("ViewData");

    }

    void onClick_List()
    {
        SceneManager.LoadScene("04_0_Cooking_preparation");
    }

    IEnumerator ViewData()
    {
        tmp = outputUrl + Indegrient_name;
       
        WWW result = DBManager.instance.GET(tmp);
        yield return result;
        Debug.Log(tmp);
       
        if (result.isDone)
        {
            JSONNode JsonData = JSON.Parse(result.text);
            Debug.Log(JsonData["results"].Count);
            for (int i=0;i<JsonData["results"].Count;i++)
             {
            string results = JsonData["results"][i]["cookname"].Value;
            itemListforIndegrient.Add(results);
            }
        }
        PopulateList();


    }
    void PopulateList()
    {
        /*
        itemList.Add("cat");
    
        itemList.Add("remen");
        StartCoroutine(ViewData());
        itemList.Add("Chicken_Mayo");
        itemList.Add("fried_rice");
        itemList.Add("Lasagna");
        itemList.Add("Olive_pasta");
        itemList.Add("Roll_sandwich");
        itemList.Add("떡볶이");
        itemList.Add("Udon");

    */
        Debug.Log("start");



        foreach (string item in itemListforIndegrient)
        {
            GameObject newButton = Instantiate(listButton) as GameObject;
            ListButton buttonScript = newButton.GetComponent<ListButton>();


            buttonScript.text.text = item; // 이름 검색해서 넣게하기
            buttonScript.image.sprite = Resources.Load<Sprite>("ListImage/" + item);

            buttonScript.button.onClick.AddListener(onClick_List);

            newButton.transform.SetParent(contentPanel);
            
        }

    }


}
