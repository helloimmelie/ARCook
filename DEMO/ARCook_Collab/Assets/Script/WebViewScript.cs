using UnityEngine;
using System.Collections;

public class WebViewScript : MonoBehaviour
{

    private WebViewObject webViewObject;
    public static bool isClicked;
    // Use this for initialization
    void Start()
    {
        //StartWebView();
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked == true)
        {
        
            if (Application.platform == RuntimePlatform.Android)
            {

                if (Input.GetKey(KeyCode.Escape))
                {
                    Destroy(webViewObject);
                    isClicked = false;
                    return;
                }
            }
        }

    }

    public void StartWebView()
    {
        isClicked = true;
        string strUrl = "http://52.79.181.122:8080/ARCook_new/board1.jsp";
       
        webViewObject =
            (new GameObject("WebViewObject")).AddComponent<WebViewObject>();
        webViewObject.Init((msg) => {
            Debug.Log(string.Format("CallFromJS[{0}]", msg));
        });

        webViewObject.LoadURL(strUrl);
        webViewObject.SetVisibility(true);
        webViewObject.SetMargins(50, 50, 50, 50);
    }
}
