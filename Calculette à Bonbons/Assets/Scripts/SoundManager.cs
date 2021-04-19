using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
   
    public Image SoundButtonMenu;
    public Image SounButtonGame;
    public Sprite[] Buttons;
    public AudioSource Audio;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    public void MusicToggle()
    {
        if(Audio.isPlaying)
        {
            Audio.Pause();
          
            SounButtonGame.GetComponent<Image>().sprite = Buttons[1];
            SoundButtonMenu.GetComponent<Image>().sprite = Buttons[1];
            Debug.Log("On");
        }
        else
        {
            Audio.Play();

            SounButtonGame.GetComponent<Image>().sprite = Buttons[0];
            SoundButtonMenu.GetComponent<Image>().sprite = Buttons[0];
            Debug.Log("Off");
        }
    }

}
