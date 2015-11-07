using UnityEngine;

public class CardDealer {
	private static CardDealer instance;
	
	private CardDealer() {}
	
	public static CardDealer Instance {
		get {
			if (instance == null) {
				instance = new CardDealer();
				Debug.Log ("New CardDealer created");
			}else {
				Debug.Log ("Use existing CardDealer");
			}
			return instance;
		}
	}

	public void dealCard() {
		GameObject[] card = new GameObject[3];
		for (int i = 0; i < 3; i++) {
			card[i] = CardFactory.Instance.getNewCard ();
			Card c = card[i].GetComponent<Card> ();
			if (c.GetType () == typeof(Joker)) {
				Joker j = (Joker)c;
				j.changeStatus(10, CardType.HEART);
			}
		}

		GameObject game_view = GameObject.FindGameObjectWithTag (ObjectTag.GAME_VIEW);
		Transform game_view_transform = game_view.transform;

		foreach (GameObject game_obj in card) {
			game_obj.transform.SetParent (game_view_transform);
			Debug.Log ("Card_dealed");
		}
	}
}
