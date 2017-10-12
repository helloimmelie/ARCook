using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;


public class Guide_BtnBack : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vtButton;
    private int S_Num
        = SceneManager.GetActiveScene().buildIndex;

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button Down!\nScene number : " + S_Num);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button Release!");
        S_Num = S_Num - 1;
        SceneManager.LoadScene(S_Num);
    }

    // Use this for initialization
    void Start () {
        vtButton = GameObject.Find("BtnBack");
        vtButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        S_Num = SceneManager.GetActiveScene().buildIndex;
     

    }
	

}
