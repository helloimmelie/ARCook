using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SimpleJSON;

[System.Serializable]

public struct cookingInformations
{

    public string cookid;
    public string cookname;

    public cookingInformations(string cookname, string cookid)
    {

        this.cookname = cookname;
        this.cookid = cookid;
    }


} 

public class CreateScroll : MonoBehaviour
{

    static List<cookingInformations> info = new List<cookingInformations>();
    public Transform contentPanel;
    public GameObject listButton;



    private string outputUrl = "http://52.79.181.122:8080/ARCook_new/cook.jsp?themenumber=10";

    IEnumerator Start()
    {
        WWW result = DBManager.instance.GET(outputUrl);
        yield return result;


        if (result.isDone)
        {
            JSONNode JsonData = JSON.Parse(result.text);
            for (int i = 0; i < JsonData["cookname"].Count; i++)
            {
                string cookname1 = JsonData["cookname"][i]["cookname"].Value;
                string cookid1 = JsonData["cookname"][i]["cookid"].Value;

                info.Add(new cookingInformations { cookname = cookname1, cookid = cookid1 });
                Debug.Log(cookname1);
                Debug.Log(cookid1);
            }
        }

        PopulateList();


    }

    void Update()
    {

    }

    public void onClick_List(string resultid)
    {
        Debug.Log("resultid :" + resultid);
        SceneManager.LoadScene("04_0_Cooking_preparation_" + resultid);
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


        foreach (cookingInformations item in info)
        {
            GameObject newButton = Instantiate(listButton) as GameObject;
            ListButton buttonScript = newButton.GetComponent<ListButton>(); 


            buttonScript.text.text = item.cookname;  
            buttonScript.image.sprite = Resources.Load<Sprite>("ListImage/" + item.cookname);
            buttonScript.id = item.cookid;

            buttonScript.button.onClick.AddListener(() => onClick_List(buttonScript.id));



            newButton.transform.SetParent(contentPanel);
            Debug.Log(item.cookname + "은 아이템에 있었다");

        }

    }

}

