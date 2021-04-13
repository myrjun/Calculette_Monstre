using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Canvas;
    bool Menuactive = true;
   
    void Update()
    {

    }
 
    public void CacaProut() 
    {
        Menuactive = false;
        Menubool();
    }

    public void ReturnButton()
    {
        Menuactive = true;
        Menubool();
    }



    public void Menubool()
    {
        if (Menuactive == true)
        {          
            Panel.SetActive(true);
            Canvas.SetActive(false);

        } else if (Menuactive == false)
        {
            Panel.SetActive(false);
            Canvas.SetActive(true);
        }

    }

   
}
