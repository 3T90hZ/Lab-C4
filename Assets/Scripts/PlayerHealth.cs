using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    // Event thông báo máu thay ??i
    public event Action<int> OnHealthChanged;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player HP: " + health);

        // Phát s? ki?n
        OnHealthChanged?.Invoke(health);
    }
}
