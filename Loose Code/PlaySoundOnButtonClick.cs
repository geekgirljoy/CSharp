using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnButtonClick : MonoBehaviour {

    public Button buttonElement;
    public AudioSource audioElement;

    void Start()
    {
        Button btn = buttonElement.GetComponent<Button>();
        btn.onClick.AddListener(PlayAudio);
    }

    void PlayAudio()
    {
        AudioSource audio = audioElement.GetComponent<AudioSource>();
        audio.Play();
    }

}
