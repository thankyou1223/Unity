using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text [ ] textList;
    void Start()
    {
        for( int i = 0; i < textList.Length; i++)
        {
            Debug.Log("textList");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
