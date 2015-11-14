using UnityEngine;
using System.Collections;

static class CardType {
	public const int HEART = 4;
	public const int DIAMOND = 3;
	public const int CLUB = 2;
	public const int SPADE = 1;
}

public class Card : MonoBehaviour, ICard {

	protected int card_number = 0;
	protected int card_type = 0;

	public void initCard(int card_number, int card_type) {
		this.card_number = card_number;
		this.card_type = card_type;
		if (this.GetType() == typeof(Joker))
			Debug.Log (" Created a new Joker");
		else
			Debug.Log (" Created a new card : Card_number = " + card_number + " and Card_type = " + card_type);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int compare(ICard other_card) {
		if (other_card.compare (this.card_number, this.card_type) == 1) {
			return -1;
		} else if (other_card.compare (this.card_number, this.card_type) == -1) {
			return 1;
		} else {
			return 0;
		}
	}

	public int compare(int card_number, int card_type) {
		if (this.card_number > card_number) {
			return 1;
		} else if (this.card_number < card_number) {
			return -1;
		} else if (this.card_type > card_type) {
			return 1;
		} else if (this.card_type < card_type) {
			return -1;
		} else {
			return 0;
		}
	}
}
