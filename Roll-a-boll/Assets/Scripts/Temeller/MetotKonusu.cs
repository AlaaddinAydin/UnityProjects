using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotKonusu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Araba oha = new Araba();

        oha.marka = "Aynen";
        oha.model = "baba";
        oha.fiyat = 200;

        print(oha.marka);
        print(oha.model);
        print(oha.fiyat);

        Araba oha1 = new Araba();

        oha1.marka = "zynen";
        oha1.model = "zaba";
        oha1.fiyat = 300;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
