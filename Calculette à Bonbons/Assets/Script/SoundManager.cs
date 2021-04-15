using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Text toggleMusictxt;
    public Text toggleMusictxtJeu;

    private void Start()
    {
        if (BgScript.BgInstance.Audio.isPlaying)
        {
            toggleMusictxt.text = "OFF";
        }
        else
        {
            toggleMusictxt.text = "ON";

        }
    }

    public void MusicToggle()
    {
        if(BgScript.BgInstance.Audio.isPlaying)
        {
            BgScript.BgInstance.Audio.Pause();
            toggleMusictxt.text = "ON";
            toggleMusictxtJeu.text = "ON";
            Debug.Log("On");
        }
        else
        {
            BgScript.BgInstance.Audio.Play();
            toggleMusictxt.text = "OFF";
            toggleMusictxtJeu.text = "OFF";
            Debug.Log("Off");
        }
    }

}
