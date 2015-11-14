using UnityEngine;
using System.Collections;

public class GameLogic {
	// class instance, must static for static getInstance
	private static GameLogic instance;

	// avoid traditional new instance
	private GameLogic (){}

	public static GameLogic Instance{
		get {
			if(instance == null){
				instance = new GameLogic();
				Debug.Log("new gamelogic created");
			} else {
				Debug.Log("gamelogic has been existing");
			}
			return instance;
		}
	}

	public void processCommand(ICommand command) {
		if (command.GetType() == typeof(DealCommand)) {
			processDealCard();
		}
	}

	private void processDealCard() {
		Debug.Log ("Deal card command sent to card dealer");
		CardDealer.Instance.dealCard ();
	}
}
