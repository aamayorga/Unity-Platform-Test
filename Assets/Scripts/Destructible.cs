using UnityEngine;
using System.Collections;

public class Destructible : MonoBehaviour {

    public Rigidbody ballRigidBody;
    public SphereCollider ballCollider;
    public Transform piecesParent;
    public Transform piecesPrefab;
    public GameObject wholeBall;

    public void Destruct () {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Collider>().enabled = false;
        var clone = Instantiate(piecesPrefab, piecesParent.position, piecesParent.rotation) as Transform;
        Destroy(clone.gameObject, 5f);
        wholeBall.SetActive(false);
    }

    public void DeDestruct() {
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Collider>().enabled = true;
        wholeBall.SetActive(true);
    }
}
