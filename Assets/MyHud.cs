using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class MyHud : MonoBehaviour {

    private NetworkManager networkManager;

	// Use this for initialization
	void Start () {
        networkManager = GetComponent<NetworkManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MyStartHost() {
        networkManager.StartHost();
        Debug.Log("Starting Host at " + Time.timeSinceLevelLoad);
    }

    void OnStartHost() {
        Debug.Log("Host started at " + Time.timeSinceLevelLoad);
    }
}
