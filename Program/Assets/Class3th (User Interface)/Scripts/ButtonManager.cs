using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text [ ] textList;
    public string [ ] contentList;

    void Start()
    {
        for(int i = 0; i < textList.Length; i++)
        {
           textList[i].text = contentList[i];
        }     
    }

    public void Execute()
    {
        Debug.Log("Execute");
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
