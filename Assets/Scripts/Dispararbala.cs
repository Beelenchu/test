﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispararbala : MonoBehaviour
{
 
    public float velocidad = 500f;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
            GetComponent<Rigidbody>().velocity = transform.forward * velocidad;
        
    }
}
