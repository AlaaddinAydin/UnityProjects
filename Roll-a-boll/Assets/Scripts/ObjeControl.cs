using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeControl : MonoBehaviour
{
    public float rotationSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3(15,30,45);
        transform.Rotate(vector * rotationSpeed);
    }
}
