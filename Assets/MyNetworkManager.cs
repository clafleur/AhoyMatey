using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class MyNetworkManager : NetworkManager {

    public void MyStartHost()
    {
        StartHost();
        Debug.Log(Time.timeSinceLevelLoad +" Starting Host at");
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " Host started at");
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client started at");
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " client is connected to IP: " + conn.address);
        CancelInvoke();
    }

    void PrintDots() {
        Debug.Log(".");
    }
}
