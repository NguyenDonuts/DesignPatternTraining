using UnityEngine;
using System.Collections;

public class GameLogic {

	private static GameLogic instance;
	
	private GameLogic() {}
	
	public static GameLogic Instance {
		get {
			if (instance == null) {
				instance = new GameLogic();
				Debug.Log ("New GameLogic created");
			}else {
				Debug.Log ("Use existing GameLogic");
			}
			return instance;
		}
	}

	public void processDealCard() {
		Debug.Log ("Deal card command sent to card dealer");
		CardDealer.Instance.dealCard ();
	}
}
