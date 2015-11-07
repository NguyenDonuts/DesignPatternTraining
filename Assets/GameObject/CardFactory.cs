using System;
using UnityEngine;

public class CardFactory {
	private static CardFactory instance;

	private CardFactory() {}

	public static CardFactory Instance {
		get {
			if (instance == null) {
				instance = new CardFactory();
			}
			return instance;
		}
	}

	public GameObject getNewCard() {
		System.Random rnd = new System.Random();
		int card_number = rnd.Next (1, 14);
		int card_type = rnd.Next (CardType.SPADE,CardType.HEART + 1);
		GameObject new_card = new GameObject ();
		if(true){
			new_card.AddComponent<Jocker>().initCard (card_number,card_type);
		}else{
			new_card.AddComponent<Card> ().initCard (card_number,card_type);
		}
		return new_card;
	}
}
