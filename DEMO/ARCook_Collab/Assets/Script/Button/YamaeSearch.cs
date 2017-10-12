using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YamaeSearch : MonoBehaviour {

    
    public void onClick()
    {
        GameObject.Find("Content").transform.Find("Button").gameObject.SetActive(true);
        //GameObject.Find("활성화된 오브젝트").transform.FindChild("비활성화된 오브젝트").gameObject.SetActive(true); 
    }
}
