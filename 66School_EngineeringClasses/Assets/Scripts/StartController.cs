using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    public string firstClick;
    public string secondClick;

    public Text text;

    int clicksCount = 0;

    void StartApplication1()
    {

    }

    public void StartApplication()
    {        
        clicksCount = clicksCount + 1;

        if (clicksCount % 2 == 0)
        {
            text.text = firstClick;            
        }
        else 
        {
            text.text = secondClick;
        }
    }

}
