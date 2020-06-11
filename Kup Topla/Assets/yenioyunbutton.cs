using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yenioyunbutton : MonoBehaviour
{
    public Button yenioyun;
    public Text oyunbittiText;

    public GameObject b1, b2, b3, b4, b5, b6, b7, b8;

    void Start()
    {

        Button btn = yenioyun.GetComponent<Button>();
        yenioyun.gameObject.SetActive(false);
        btn.onClick.AddListener(TaskOnClick);
    }


    void Update()
    {

    }

    void TaskOnClick()
    {
        b1.SetActive(true);
        b2.SetActive(true);
        b3.SetActive(true);
        b4.SetActive(true);
        b5.SetActive(true);
        b6.SetActive(true);
        b7.SetActive(true);
        b8.SetActive(true);
        yenioyun.gameObject.SetActive(false);
        oyunbittiText.text = "";
    }
}
