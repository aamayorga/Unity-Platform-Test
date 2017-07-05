using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {

    bool isRestarting = false;
    float maxFallDistance = -10;

    public GameMaster gameMaster;

	// Update is called once per frame
	void Update () {
	    if (transform.position.y <= maxFallDistance) {
            if (GameMaster.isRestarting == false) {
                gameMaster.RestartLevel();
            }
        }
	}

    
}
