using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTable : MonoBehaviour
{
    [SerializeField] Text text;

    public void Entered()
    {
        text.fontSize = 100;
    }

    public void Exited()
    {
        text.fontSize = 75;
    }

    public void Selected() 
    {
        text.fontSize = 50;
    }
}
