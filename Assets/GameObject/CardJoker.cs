using UnityEngine;
using System.Collections;

public class CardJoker : Card, IJoker {


	public void changeStatus(int card_number, int card_type){
		this.card_number = card_number;
		this.card_type = card_type;
		Debug.Log ("change to card : Card_number = " + card_number + " and Card_type = " + card_type);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
