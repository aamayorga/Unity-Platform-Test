using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinalScoreGUI : MonoBehaviour {

    public Text scoreText;

	void Start() {
        scoreText.text = "Score: " + GameMaster.finalScore;
    }
}
