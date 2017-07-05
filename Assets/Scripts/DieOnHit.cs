using UnityEngine;
using System.Collections;

public class DieOnHit : MonoBehaviour {

    public Rigidbody player;

	void OnTriggerEnter() {
        Enemy enemy = transform.GetComponentInParent<Enemy>();
        enemy.Die();
    }
}
