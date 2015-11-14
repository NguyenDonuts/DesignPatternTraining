using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface ICommand{

}

public class DealCommand : ICommand{

}

public class PlayerCommandBus : MonoBehaviour {
	private Queue<ICommand> command_queue;

	// Use this for initialization
	void Start () {
		command_queue = new Queue<ICommand>();
	}
	
	// Update is called once per frame
	void Update () {
		while (command_queue.Count > 0) {
			ICommand command = command_queue.Dequeue();
			GameLogic.Instance.processCommand(command);	                                 
		}
	}

	public void addCommand(ICommand command) {
		command_queue.Enqueue (command);
	}
}
