using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topkontrol : MonoBehaviour
{

    Rigidbody fizik;
    public int hiz;
    public int toplanacaknesnesayisi;
    int sayac = 0;
    public Text sayacText;
    public Text oyunbittiText;
    public Button yenioyun;


    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

       
        Vector3 vec = new Vector3(yatay, 0,dikey);

        fizik.AddForce(vec*hiz);
    }
   
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "topla")
        {
            other.gameObject.SetActive(false);
            sayac++;

            sayacText.text = "Sayac= " + sayac;

            if (sayac%8==0)
            {
                oyunbittiText.text = "Oyun Bitti";
                yenioyun.gameObject.SetActive(true);
            }
            
        }
    }


 
}
