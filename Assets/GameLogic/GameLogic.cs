using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void processDealCard() {
		Debug.Log ("Deal card command sent to card dealer");
		CardDealer.Instance.dealCard ();
	}
}
