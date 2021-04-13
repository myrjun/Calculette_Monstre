using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Text toggleMusictxt;

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
        }
        else
        {
            BgScript.BgInstance.Audio.Play();
            toggleMusictxt.text = "OFF";
        }
    }

}
