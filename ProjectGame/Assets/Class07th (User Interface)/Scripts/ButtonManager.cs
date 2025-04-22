using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    // inspecter -> textlist »ý¼º
    [SerializeField] Text[] textList;
    //string array feild
    [SerializeField] string[] titleList;

    private void Start()
    {
        for (int i = 0; i < textList.Length; i++)
        {
            textList[i].text = titleList[i];
        }
    }

    public void Execute()
    {
        Debug.Log("Execute\n");
    }

    public void Shop()
    {
        Debug.Log("Shop");
    }

    public void Quit()
    {
        Debug.Log("Quit");
    }
}