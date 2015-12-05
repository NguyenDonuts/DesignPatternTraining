using UnityEngine;

public class CardDealer {
	private static CardDealer instance;
	
	private CardDealer() {}
	Sprite card_1_u = Resources.Load("card_1", typeof(Sprite)) as Sprite;
	Sprite card_2_u = Resources.Load("card_2", typeof(Sprite)) as Sprite;
	Sprite card_3_u = Resources.Load("card_3", typeof(Sprite)) as Sprite;
	Sprite jocker = Resources.Load("joker", typeof(Sprite)) as Sprite;
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
	public void processCommand(GameCommand command) {
		if (command.GetType() == typeof(GameCommand)) {
			dealCard();
		}
	}
	

	public void dealCard() {
		GameObject card_1 = CardFactory.Instance.getNewCard ();
		GameObject card_2 = CardFactory.Instance.getNewCard ();
		GameObject card_3 = CardFactory.Instance.getNewCard ();
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
		card_1.transform.SetParent (game_view_transform);
		card_1.transform.position = new Vector3 (0, 0, 0);
		card_1.AddComponent<SpriteRenderer>();
		if (card_1.GetComponent<Joker> ()) {
			card_1.GetComponent<SpriteRenderer>().sprite = jocker;
		} else {
			card_1.GetComponent<SpriteRenderer>().sprite = card_1_u;
		}

		card_2.transform.SetParent (game_view_transform);
		card_2.AddComponent<SpriteRenderer>();
		card_2.transform.position = new Vector3 (-1.88f, 0, 0);
		if (card_2.GetComponent<Joker> ()) {
			card_2.GetComponent<SpriteRenderer>().sprite = jocker;
		} else {
			card_2.GetComponent<SpriteRenderer>().sprite = card_2_u;
		}


		card_3.transform.SetParent (game_view_transform);
		card_3.AddComponent<SpriteRenderer>();
		card_3.transform.position = new Vector3 (1.57f, 0, 0);

		if (card_3.GetComponent<Joker> ()) {
			card_3.GetComponent<SpriteRenderer>().sprite = jocker;
		} else {
			card_3.GetComponent<SpriteRenderer>().sprite = card_2_u;
		}

		Debug.Log ("Card_dealed");
	}
}
