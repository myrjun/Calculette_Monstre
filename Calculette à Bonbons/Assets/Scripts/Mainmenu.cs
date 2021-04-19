using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Canvas;
    bool Menuactive = true;

    public void Start()
    {
        Menu.SetActive(true);
        Canvas.SetActive(false);
    }
 
    public void PlayButton() 
    {
        Menuactive = false;
        MenuCondition();
    }

    public void ReturnButton()
    {
        Menuactive = true;
        MenuCondition();
    }

    public void MenuCondition()
    {
        if (Menuactive == true)
        {          
            Menu.SetActive(true);
            Canvas.SetActive(false);

        } else if (Menuactive == false)
        {
            Menu.SetActive(false);
            Canvas.SetActive(true);
        }

    }

   
}
