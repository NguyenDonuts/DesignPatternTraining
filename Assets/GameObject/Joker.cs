using UnityEngine;

public class Joker : Card, IJoker
{
	public Joker ()
	{
	}

	public void changeStatus (int card_number, int card_type)
	{
		this.card_number = card_number;
		this.card_type = card_type;
		Debug.Log("Joker has changed his face to " + card_number + " " + card_type);
	}
}
