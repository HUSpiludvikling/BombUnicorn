﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class KillPlane : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
          //  collision.gameObject.GetComponent<Damageable>().TakeDamage()
        }
    }
}
