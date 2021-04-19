using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class CalculetteManager : MonoBehaviour
{
    public int CurrentButtonNumber;
    public GameObject ResultOnScreen;
    public Text Chiffre1Screen;
    public Text OperationScreen;
    public Text Chiffre2Screen;
    public string[] ResultToApply;
    public string[] Chiffres;
    public string[] Operations;

    private Text Result;
    private bool BtnOneIn;
    private bool OperationIn;

    private string btnChiffre1;
    private string btnChiffre2;
    private string btnname;
    private string btnOperation;
    private string ResultForCalcul;

    private int chiffre1;
    private int chiffre2;
    private int ResultF;
    private int OperationType;
    private int n;


    void Start()
    {
        Result = ResultOnScreen.GetComponent<Text>();
        Result.text = ResultToApply[0];
        BtnOneIn = false;
    }


    public void DisplayResult()
    {
        btnname = EventSystem.current.currentSelectedGameObject.name;
    
        for (int i = 0; i < Chiffres.Length; i++)
        {
            if (btnname == Chiffres[i])
            {
                if (BtnOneIn == false)
                {
                    btnChiffre1 = btnname;
                    Chiffre1Screen.text = btnChiffre1;
                    Chiffre2Screen.text = " ";
                    OperationScreen.text = " ";
                    BtnOneIn = true;
                    OperationIn = false;

                }
                else if (BtnOneIn == true && OperationIn == true)
                {
                    btnChiffre2 = btnname;
                    Chiffre2Screen.text = btnChiffre2;
                    BtnOneIn = false;

                }
            }

        }      
    }

    public void OperationsButtons()
    {
        btnname = EventSystem.current.currentSelectedGameObject.name;

        for (int j = 0; j < Operations.Length; j++)
        {
            if (btnname == Operations[j] && OperationIn == false)
            {
                btnOperation = btnname;
                OperationScreen.text = btnOperation;
                OperationIn = true;
                //Operation[j] = 
            }
        }

    }

    public void ButtonOK()
    {
        ResultatCalcul();
        Chiffre1Screen.text = " ";
        Chiffre2Screen.text = " ";
        OperationScreen.text = " ";
        BtnOneIn = false;
    }


    public void ResultatCalcul()
    {
        btnChiffre1 = Chiffre1Screen.GetComponent<Text>().text;
        btnChiffre2 = Chiffre2Screen.GetComponent<Text>().text;
        ResultForCalcul = Result.text;

        int.TryParse(btnChiffre1, out chiffre1);
        int.TryParse(btnChiffre2, out chiffre2);
        int.TryParse(ResultForCalcul, out ResultF);

        Debug.Log(chiffre2);
        Debug.Log(ResultF);

        if (btnOperation == "x")
        {
            //int CalculResult = btnChiffre1 * btnChiffre2;

            if (ResultF == chiffre1 * chiffre2)
            {
                Debug.Log("it works *");
                LevelUp();
            }
            else
            {
                Debug.Log("false");
            }
        }
        else if (btnOperation == "-")
        {
            if (ResultF == chiffre1 - chiffre2)
            {
                Debug.Log("it works -");
                LevelUp();
            }
            else
            {
                Debug.Log("false");
            }
        }
        else if (btnOperation == "+")
        {
            if (ResultF == chiffre1 + chiffre2)
            {
                Debug.Log("it works +");
                LevelUp();
            }
            else
            {
                Debug.Log("false");
            }
        }

    }

    public void LevelUp()
    {
        if(n < 4)
        {
            n++;
            Result.text = ResultToApply[n];
        }

        if(n == 4)
        {
            EndOfGame();
        }
       
    }

    public void EndOfGame()
    {
        Debug.Log("END");
    }


}
