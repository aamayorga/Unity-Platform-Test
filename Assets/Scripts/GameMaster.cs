using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameMaster : MonoBehaviour {

    static public bool isRestarting = false;
    public Transform player;
    public static int finalScore;
    public static int currentScore = 0;
    public Text score;
    public Transform musicPrefab;
    private AudioSource audio;
    public AudioClip GameOverSound;

    void Start () {
        audio = GetComponent<AudioSource>();
        currentScore = 0;

        if (!GameObject.FindGameObjectWithTag("MM")) {
            var mManager = Instantiate(musicPrefab, transform.position, Quaternion.identity);
            mManager.name = musicPrefab.name;
            DontDestroyOnLoad(mManager);

        }
    }

    void Update() {
        score.text = "Score: " + currentScore.ToString();
    }

    public void RestartLevel() {
        isRestarting = true;
        audio.pitch = 1;
        audio.clip = GameOverSound;
        audio.Play();
        new WaitForSeconds(audio.clip.length);
        player.position = Checkpoint.ReachedPoint;
        Destructible destructable = player.GetComponent("Destructible") as Destructible;
        destructable.DeDestruct();
        isRestarting = false;
    }

    public void LoadNextLevel() {
        Application.LoadLevel(Application.loadedLevel + 1);
        finalScore += currentScore;
    }
}
