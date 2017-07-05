using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

    public float rotationSpeed = 100;
    public float jumpHeight = 8;

    private bool isFalling = false;
    private bool playOnce = true;
    private AudioSource audio;

    public AudioClip[] hitSounds;

    void Start() {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

        // Handle ball rotation
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        GetComponent<Rigidbody>().AddRelativeTorque(Vector3.back * rotation);

        if (Input.GetKeyDown(KeyCode.W) && isFalling == false) {
            playOnceTrue();
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        }
        isFalling = true;
    }

    void OnCollisionStay(Collision collision) {

        if (playOnce == true) {
            var theHit = Random.Range(0, 3);
            audio.clip = hitSounds[theHit];
            audio.pitch = Random.Range(0.9f, 1.1f);
            audio.Play(); 
            playOnce = false;
        }
        isFalling = false;
    }

    void playOnceTrue () {
        new WaitForSeconds(0.2f);
        playOnce = true;
    }
}
