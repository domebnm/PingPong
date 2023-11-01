using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    int counter1, counter2;
    TextMeshProUGUI text;
    [SerializeField] SceneGameStart gameStart;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public void SetAdd(int a, int b) // counter1 + a : counter2 + b
    {
        counter1 += a;
        counter2 += b;
        text.text = counter1 + ":" + counter2;

        if (a == 0) StartCoroutine(gameStart.StartScene(1));
        else StartCoroutine(gameStart.StartScene(-1));
    }
}
