﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinLetters : MonoBehaviour {

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 50, 0);
    }
}
