using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class BallControl : MonoBehaviour
{
    public TextMeshProUGUI GameOver , ExtraReward , TimerText , GameOverRed;
    public int Speed , JumpRate;
    public bool BallOnGround = true , TimerOn = false;
    public float TimeLeft = 30;
    Rigidbody Rg;
    Vector3 Force , JumpForce;
    
    // Start is called before the first frame update
    void Start()
    {
        Rg = GetComponent<Rigidbody>();
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        float Yatay = Input.GetAxis("Horizontal");
        float Dikey = Input.GetAxis("Vertical");

        Force = new Vector3(Yatay, 0 , Dikey);
        JumpForce = new Vector3(0,1,0);

        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                TimerText.text = "Time : " + Math.Floor(TimeLeft);
            }
            else
            {
                TimeLeft = 0;
                TimerOn = false;
                Time.timeScale = 0;
                GameOverRed.gameObject.SetActive(true);
            }
        }

        

        Rg.AddForce(Force * Speed);

        if(Input.GetButtonDown("Jump") && BallOnGround){
            Rg.AddForce(JumpForce * JumpRate, ForceMode.Impulse);
            BallOnGround = false;
        }
        
    }

      void OnCollisionEnter(Collision other)
     {
        if(other.gameObject.name == "FinishLine")
        {
            GameOver.gameObject.SetActive(true);
            TimerOn = false;
            Time.timeScale = 0;
        }
        if(other.gameObject.tag == "Ground")
        {
            BallOnGround = true;
        }
        
     }
    
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);

        ExtraReward.gameObject.SetActive(true);
    }
}
