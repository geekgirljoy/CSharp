using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSceneOnButtonClick : MonoBehaviour {

    public Button myButton;
    public string SceneName = "";

    // Use this for initialization
    void Start ()
    {
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(Go);
    }

    void Go()
    {
        Application.LoadLevel(SceneName);
    }
}
