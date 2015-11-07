using UnityEngine;
using System.Collections;

public class PlayerCommandBus : MonoBehaviour {

	private GameLogic game_logic;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void dealCard() {
		Debug.Log ("Deal Card Commanded");
		GameLogic.Instance.processDealCard ();
	}
}
