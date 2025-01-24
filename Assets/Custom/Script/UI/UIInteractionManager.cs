using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInteractionManager : MonoBehaviour
{
    [SerializeField]
    private GameObject VRrig;
    [SerializeField]
    private GameObject ARrig;
    [SerializeField]
    private GameObject VRCanvas;
    [SerializeField]
    private GameObject ARCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnVRSelect()
    {
        Debug.Log("VR Button Is Working");
        ARrig.SetActive(false);
        VRrig.SetActive(true);
        ARCanvas.SetActive(false);
        VRCanvas.SetActive(true);
    }
    public void OnARSelect()
    {
        Debug.Log("AR Button Is Working");
        VRrig.SetActive(false);
        ARrig.SetActive(true);
        VRCanvas.SetActive(false);
        ARCanvas.SetActive(true);
    }
}
