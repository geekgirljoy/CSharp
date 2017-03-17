using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ViewAdOnButtonClick : MonoBehaviour {

    public Button buttonElement;

    // Use this for initialization
    void Start () {
        Button btn = buttonElement.GetComponent<Button>();
        btn.onClick.AddListener(ShowAd);
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }

}
