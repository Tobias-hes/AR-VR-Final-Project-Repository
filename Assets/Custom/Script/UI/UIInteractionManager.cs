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
    [SerializeField]
    private GameObject VRGameSelectCanvas;
    [SerializeField]
    private GameObject ARGameSelectCanvas;

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

        VRGameSelectCanvas.SetActive(true);
        ARGameSelectCanvas.SetActive(false);
    }
    public void OnARSelect()
    {
        Debug.Log("AR Button Is Working");
        VRrig.SetActive(false);
        VRCanvas.SetActive(false);
        VRGameSelectCanvas.SetActive(false);

        
        ARrig.SetActive(true);
        ARCanvas.SetActive(true);
        ARGameSelectCanvas.SetActive(true);
    }
    public void LoadCatching()
    {
        Debug.Log("AR Button Is Working");
        
    }
    public void LoadDodge()
    {
        Debug.Log("AR Button Is Working");

    }
    public void LoadMemory()
    {
        Debug.Log("AR Button Is Working");

    }

}
