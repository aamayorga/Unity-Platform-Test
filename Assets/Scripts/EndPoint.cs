using UnityEngine;
using System.Collections;

public class EndPoint : MonoBehaviour {

    public GameMaster gameMaster;

	void OnTriggerEnter(Collider colInfo) {
        if (colInfo.tag == "Player") {
            gameMaster.LoadNextLevel();
        }
    }
}
