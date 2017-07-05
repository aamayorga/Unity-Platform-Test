using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public AudioSource music;

	public void QuitGame() {
        Application.Quit();
    }

    public void StartGame(string level) {
        Application.LoadLevel(level);
    }

    public void SetGameVolume(float vol) {
        music.volume = vol;
    }
}
