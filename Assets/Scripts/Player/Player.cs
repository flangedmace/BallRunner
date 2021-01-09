using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using System;

public class Player : MonoBehaviour
{
    public int Coins => _coins;
    public UnityAction Death;

    [SerializeField] private TextMeshProUGUI _coinsText;

    private int _coins = 0;

    public void TakeCoin()
    {
        _coins++;

        UpdateText();
    }

    private void Start()
    {
        UpdateText();
    }

    private void UpdateText()
    {
        _coinsText.text = Convert.ToString(_coins);
    }
}
