using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeShow : MonoBehaviour
{
    public Text curTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime NowTime = System.DateTime.Now.ToLocalTime();
        curTime.text = NowTime.ToString("HH:mm:ss");
    }
}
