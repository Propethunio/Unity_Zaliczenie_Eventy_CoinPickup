using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{

    public static CoinCounter instance;

    public EventHandler OnCoinPickup;

    int coinCount;
    [SerializeField] TMP_Text text;

    private void Awake() {
        instance = this;
    }

    void Start()
    {
        OnCoinPickup += OnPickup;
    }

    void OnPickup(object sender, EventArgs e) {
        coinCount++;
        text.text = $"Coins: {coinCount}";
    }
}