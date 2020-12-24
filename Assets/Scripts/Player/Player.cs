using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinstext;

    public int Coins => _coins;

    public UnityAction Death;

    private int _coins = 0;

    private void Start()
    {
        SetCoinsText();
    }

    public void TakeCoin()
    {
        _coins++;

        SetCoinsText();
    }

    private void SetCoinsText()
    {
        _coinstext.text = Convert.ToString(_coins);
    }
}
