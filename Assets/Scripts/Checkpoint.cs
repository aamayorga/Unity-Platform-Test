using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Checkpoint : MonoBehaviour {

    public static Vector3 ReachedPoint = new Vector3(0, 2, 0);

	void OnTriggerEnter(Collider col) {
        if (col.tag == "Player") {
            if (transform.position.x > ReachedPoint.x) {
                ReachedPoint = transform.position;
            }
        }
    }
}
