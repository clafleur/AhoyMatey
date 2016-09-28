using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

public class Player : MonoBehaviour
{

    private Vector3 inputValue;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
        inputValue.y = 0.0f;
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");

        transform.Translate(inputValue);
    }
}