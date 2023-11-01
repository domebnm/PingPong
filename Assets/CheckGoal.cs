using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckGoal : MonoBehaviour
{
    [SerializeField] int a, b;
    [SerializeField] Counter counter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        counter.SetAdd(a, b);
    }
}
