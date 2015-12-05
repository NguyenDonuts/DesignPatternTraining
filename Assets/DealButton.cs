using UnityEngine;
using System.Collections;

public class DealButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void buttonClicked() {
		PlayerCommandBus command_bus = (PlayerCommandBus)GameObject.FindGameObjectWithTag (ObjectTag.PLAYER_COMMAND_BUS).GetComponent (typeof(PlayerCommandBus));
		command_bus.addCommand(new DealCommand());
	}
}
