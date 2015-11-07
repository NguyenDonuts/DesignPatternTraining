using UnityEngine;


public class GameLogic{

    private static GameLogic instance;
    private GameLogic() { }

    public static GameLogic Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameLogic();
                Debug.Log("New GameLogic created");
            }
            else
            {
                Debug.Log("Use existing GameLogic");
            }
            return instance;
        }
    }
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
