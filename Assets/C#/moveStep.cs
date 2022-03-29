using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveStep : MonoBehaviour
{
    public GameObject castle;       //������������Ӧ
    public float value;             //�޸ĵ�ֵ
    public Vector3 sizeChange;      //��������ĳߴ����

    // Start is called before the first frame update
    void Start()
    {
        value = 120;                //��ʼֵx�᣿Ϊ120
        sizeChange = Vector3.one;  //����Ϊ0
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveLeft()
    {
        value = value - 3f;
        castle.transform.position = new Vector3(value, -20, 130);
    }
    public void MoveRight()
    {
        value = value + 3f;
        castle.transform.position = new Vector3(value, -20, 130);
    }
    public void Rotate()
    {
        castle.transform.Rotate(0f, 10f, 0f);
    }
    public void Grow()
    {
        castle.transform.localScale = castle.transform.localScale + sizeChange;
    }
    public void ResetObj()
    {
        castle.transform.position = new Vector3(120, -20, 130);
        castle.transform.rotation = Quaternion.Euler(new Vector3(0, -57, 0));
        castle.transform.localScale = new Vector3(1, 1, 1);
    }

}
