﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text cherryCount;
    public GameObject head;

    void Start()
    {
        
    }

    void Update()
    {
        cherryCount.text = head.GetComponent<HeadMoving>().chereshnyaCount.ToString();
    }
}
