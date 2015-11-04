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
		GameObject card_1 = CardFactory.Instance.getNewCard ();
		GameObject card_2 = CardFactory.Instance.getNewCard ();
		GameObject card_3 = CardFactory.Instance.getNewCard ();
		GameObject game_view = GameObject.FindGameObjectWithTag (ObjectTag.GAME_VIEW);
		Transform game_view_transform = game_view.transform;
		card_1.transform.SetParent (game_view_transform);
		card_2.transform.SetParent (game_view_transform);
		card_3.transform.SetParent (game_view_transform);
		Debug.Log ("Card_dealed");
	}
}
