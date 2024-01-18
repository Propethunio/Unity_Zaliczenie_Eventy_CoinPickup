using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            CoinCounter.instance.OnCoinPickup?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);
        }
    }
}