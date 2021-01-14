using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class Player : MonoBehaviour
{
    public UnityAction Death;

    public int Coins => _coins;

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
