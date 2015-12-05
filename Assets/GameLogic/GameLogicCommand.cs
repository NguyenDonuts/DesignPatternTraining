using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface ICommandGameLogic{
	
}

public class GameCommand : ICommandGameLogic{
	
}

public class GameLogicCommand : MonoBehaviour {
	private Queue<ICommandGameLogic> command_queue;
	// Use this for initialization
	void Start () {
		command_queue = new Queue<ICommandGameLogic>();
	}
	
	// Update is called once per frame
	void Update () {
		while (command_queue.Count > 0) {
			ICommandGameLogic command = command_queue.Dequeue();
			CardDealer.Instance.dealCard();
		}
	}
	
	public void addCommand(ICommandGameLogic command) {
		command_queue.Enqueue (command);
	}
}
