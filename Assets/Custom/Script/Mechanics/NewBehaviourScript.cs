using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public class DropCylinder : MonoBehaviour
    {
        float time = 1;
        float timeCheck = 0;
        private Rigidbody[] tempCylinders;

        private List<Rigidbody> cylinders;

        [SerializeField]
        float dropRateFloor = 1.00f;

        [SerializeField]
        float dropRateRoof = 3.00f;

        [SerializeField]
        private GameObject VRrig;

        [SerializeField]
        private GameObject ARrig;

        [SerializeField]
        private GameObject VRCanvas;

        [SerializeField]
        private GameObject ARCanvas;


        // Start is called before the first frame update
        //https://www.c-sharpcorner.com/article/how-to-remove-an-element-from-an-array-in-c-sharp/#:~:text=To%20remove%20an%20element%20from%20an%20array%20in%20C%23%2C%20you,element%20you%20want%20to%20remove.

        void Start()
        {

            tempCylinders = GetComponentsInChildren<Rigidbody>();
            cylinders = new List<Rigidbody>();
            for (int j = 0; j < tempCylinders.Length; j++)
            {
                cylinders.Add(tempCylinders[j]);
            }
        }

        // Update is called once per frame
        void Update()
        {



        }
        void FixedUpdate()
        {
            //https://docs.unity3d.com/6000.0/Documentation/Manual/class-TimeManager.html
            timeCheck += 0.02f;
            if (cylinders != null)
            {
                if (timeCheck >= time)
                {
                    //https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Random.Range.html
                    float randomTime = Random.Range(dropRateFloor, dropRateRoof);
                    int randmonCylinder = Random.Range(0, cylinders.Count);
                    if (cylinders.Count == 1)
                    {
                        time += randomTime;
                        cylinders[0].useGravity = true;
                        cylinders.RemoveAt(0);
                    }
                    else if (cylinders.Count > 1)
                    {
                        time += randomTime;
                        cylinders[randmonCylinder].useGravity = true;
                        cylinders.RemoveAt(randmonCylinder);
                    }

                }
                else if (cylinders.Count == 0)
                {
                    //https://docs.unity3d.com/6000.0/Documentation/ScriptReference/SceneManagement.SceneManager.html

                    if (VRrig == null)
                    {

                       
                        ARrig.SetActive(false);
                        VRrig.SetActive(true);
                        ARCanvas.SetActive(false);
                        VRCanvas.SetActive(true);
                    }
                    else
                    {

                        
                        VRrig.SetActive(false);
                        ARrig.SetActive(true);
                        VRCanvas.SetActive(false);
                        ARCanvas.SetActive(true);
                    }
                }
            }
        }
    }
}
