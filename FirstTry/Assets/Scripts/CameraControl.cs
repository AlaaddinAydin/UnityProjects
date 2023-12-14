using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    Vector3 fark;
    // Start is called before the first frame update
    void Start()
    {
        fark = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + fark;
    }
}
