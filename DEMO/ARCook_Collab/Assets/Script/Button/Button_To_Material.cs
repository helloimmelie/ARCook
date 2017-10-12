using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_To_Material : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("02_2_material cooking");
    }
}
