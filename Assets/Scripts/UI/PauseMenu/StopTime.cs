﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTime : MonoBehaviour {
    
    public void ChangeTime(int speed)
    {
        Time.timeScale = speed;
    }
}
