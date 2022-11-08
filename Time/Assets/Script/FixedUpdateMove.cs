﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    void FixedUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime*moveSpeed);
    }
}
