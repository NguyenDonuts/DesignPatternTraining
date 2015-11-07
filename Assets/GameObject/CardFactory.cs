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
		GameObject new_card = new GameObject ();
		if (rnd.Next (0, 5) == 0) {
			new_card.AddComponent<Joker> ().initCard (0, 0);
		} else {
			int card_number = rnd.Next (1, 15);
			int card_type = rnd.Next (CardType.SPADE, CardType.HEART + 1);
			new_card.AddComponent<Card> ().initCard (card_number, card_type);
		}
		return new_card;
	}
}
