using UnityEngine;
using System.Collections;

public class PlayerCommandBus : MonoBehaviour {

	// private GameLogic game_logic;

	// Use this for initialization
	void Start () {
		// game_logic = (GameLogic) GameObject.FindGameObjectWithTag(ObjectTag.GAME_LOGIC).GetComponent(typeof(GameLogic));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void dealCard() {
		Debug.Log ("Deal Card Commanded");
		// game_logic.processDealCard ();
		GameLogic.Instance.processDealCard();
	}
}
