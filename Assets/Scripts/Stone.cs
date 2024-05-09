﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public float lifeTime;
   
    void Start()
    {
        Invoke("DestroyStone", lifeTime);
    }

    private void DestroyStone()
    {
        Destroy(gameObject);
    }
}