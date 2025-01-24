using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.Events;


public class Trackedmanager : MonoBehaviour
{
    //List of tracked devices
    List<InputDevice> devices;
    public XRNode controllerNode;
    public GameObject ball;

    //events
    public UnityEvent OnPress;
    public UnityEvent OnRelease;
    private bool isPressed = false;

    private void Awake()
    {
        devices = new List<InputDevice>();
    }

    public void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(controllerNode, devices);
        



    }


    // Start is called before the first frame update
    void Start()
    {
        GetDevice();

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var device in devices)
        {
            //Debug.Log(device.name + " " + device.characteristics);
            if (device.isValid)
            {
                Vector3 position;
                if (device.TryGetFeatureValue(CommonUsages.devicePosition, out position))
                {
                    //Debug.Log(device.name + " " + position);

                }
                Quaternion rotation;
                if (device.TryGetFeatureValue(CommonUsages.deviceRotation, out rotation))
                {
                    //Debug.Log(device.name + " " + rotation);

                }
                bool inputValue;
                if (device.TryGetFeatureValue(CommonUsages.primaryButton, out inputValue) && inputValue)
                {
                    if (!isPressed)
                    {
                        isPressed = true;
                        //Debug.Log("OnPress Event Is Called!");
                        OnPress.Invoke();


                    }
                }
                else if (isPressed)
                {
                    isPressed = false;
                    //Debug.Log("OnRelease Event Is Called!");
                    OnRelease.Invoke();

                }

            }
        }

    }
    public void EnableBall()
    {
        ball.SetActive(true);
    }
}
