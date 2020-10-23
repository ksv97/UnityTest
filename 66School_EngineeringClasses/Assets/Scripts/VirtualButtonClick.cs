using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonClick : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject trafficLight;
    public GameObject vButton;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        trafficLight.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        trafficLight.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
