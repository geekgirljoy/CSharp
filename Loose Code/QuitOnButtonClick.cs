using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitOnButtonClick : MonoBehaviour {

    public Button myButton;

    void Start()
    {
        Button Btn = myButton.GetComponent<Button>();
        Btn.onClick.AddListener(ChangeScene);
    }

    void ChangeScene()
    {
        Application.Quit();
    }
}
