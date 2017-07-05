using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public Transform target;
    public float distance = -10;
    public float lift = 1.5f;

    void LateUpdate() {
        transform.position = target.position + new Vector3(0, lift, distance);
        transform.LookAt(target);
    }
}
