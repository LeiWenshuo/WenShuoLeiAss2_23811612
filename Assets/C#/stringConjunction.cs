using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stringConjunction : MonoBehaviour
{
    public string str1, str2, str;
    public InputField input1, input2;
    public Text result;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StrConjuction()
    {
        str1 = input1.text;
        str2 = input2.text;
        str = str1 + str2;
        result.text = str;
    }
}
