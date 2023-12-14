using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DuckController : MonoBehaviour
{
    
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(0,0,1);
        transform.Rotate(rotation * rotationSpeed);
    }

    
}
