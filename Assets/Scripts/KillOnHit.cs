using UnityEngine;
using System.Collections;

public class KillOnHit : MonoBehaviour {

    public GameMaster gameMaster;

	void OnTriggerEnter(Collider colInfo) {
        if (GameMaster.isRestarting == false) {
            if (colInfo.tag == "Player") {
                Destructible destructable = colInfo.GetComponent("Destructible") as Destructible;
                destructable.Destruct();
            }
            gameMaster.RestartLevel();
        }
    }
}
