﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Update()
    {
        this.transform.Translate(0, 0,Time.deltaTime*moveSpeed);
    }
}
