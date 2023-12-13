using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TopControl : MonoBehaviour
{
    public Rigidbody fizik;
    public int hiz;
    public int puan;
    public int objeSayısı;
    public TextMeshProUGUI puanText;
    public TextMeshProUGUI oyunBitti;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(0,0,-10);
        fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
        //transform.Translate(0.01f,0,-0.01f);
        //transform.Rotate(0,0,0.1f);

        // if(Input.GetKeyDown(KeyCode.Escape))
        // {
        //     Debug.Log("Basma lan");
        // }
        // if(Input.GetKeyDown(KeyCode.E))
        // {
        //     Debug.Log("E'ye bas");
        // }
        
        float yatay = Input.GetAxis("Horizontal");
        float dikey =  Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(yatay,0,dikey);
        
        // Debug.Log("Yatay " + yatay + " Dikey " + dikey);

        fizik.AddForce(vector*hiz);

        //Debug.Log(transform.position);
    }

    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);

        other.gameObject.SetActive(false);
        //puan +=1;
        puan++;
        
        
        puanText.text = "Puan: " + puan;

        if(puan == objeSayısı)
        {
            oyunBitti.gameObject.SetActive(true);
        }
    }

    // void OnTriggerExit(Collider other)
    // {
    //     other.gameObject.SetActive(false);
    // }

    // void OnTriggerStay(Collider other)
    // {
    //     //other.gameObject.SetActive(false);

    //     Debug.Log("Temas Edildi");
    // }
}
