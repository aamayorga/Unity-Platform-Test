using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    
    public Rigidbody player;
    public float bounceAmount;
    public Transform deathParticles;

    public AudioSource deathSound;
    public Animator enemyAnim;
    public Transform colliders;
    private Animator centerAnim;

    void Awake() {
        centerAnim = transform.GetComponent<Animator>();
    }

    public void Die() {
        player.velocity = new Vector3(player.velocity.x, bounceAmount, player.velocity.z);
        Instantiate(deathParticles, enemyAnim.transform.position, enemyAnim.transform.rotation);
        deathSound.Play();
        enemyAnim.SetTrigger("Die");
        centerAnim.SetTrigger("Stop");
        Destroy(colliders.gameObject);
    }
}