using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S01 : MonoBehaviour
{
    public Button btn;
    public Image ima;

    private void Awake()
    {
        btn.onClick.AddListener(OnbtnClick);

       
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnbtnClick()
    {
        Debug.Log("oooo~");

        ima.color = new Color(0.6f, 0.1f, 0.6f);

        ima.transform .localPosition= new Vector3(20, 30, 0);

    }
}
