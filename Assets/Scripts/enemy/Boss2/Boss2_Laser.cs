﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2_Laser : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
