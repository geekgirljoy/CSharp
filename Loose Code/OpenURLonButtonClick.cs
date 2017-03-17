using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenURLonButtonClick : MonoBehaviour {

    public Button buttonElement;
    public string URL;

    // Use this for initialization
    void Start () {
        Button btn = buttonElement.GetComponent<Button>();
        btn.onClick.AddListener(LoadURL);
    }
	
	void LoadURL()
    {
        Application.OpenURL(URL);
    }
}
