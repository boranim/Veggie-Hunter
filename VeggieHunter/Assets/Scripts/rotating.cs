﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 50 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
