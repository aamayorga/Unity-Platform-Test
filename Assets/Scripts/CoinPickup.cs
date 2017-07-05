using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

    public Transform coinEffect;
    public int coinValue = 1;

    // Update is called once per frame
    void OnTriggerEnter(Collider collider) {
        if (collider.name == "Ball") {
            GameMaster.currentScore += coinValue;
            Object effect = Instantiate(coinEffect, transform.position, transform.rotation);
            Destroy((effect as Transform).gameObject, 3);
            Destroy(gameObject);
        }
    }
}
