using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    public Activator button;
    public Material normal;
    public Material transparent;
    //private CubeMovement update;
    public bool canPush;
    bool posChenger = true;
    int Timer;
    public double trimercount;

/*
    IEnumerator fade()
    {
        transform.position = transform.position + new Vector3(0, -0.05f, 0);

        yield return new WaitForSeconds(3.0f);

        transform.position = transform.position + new Vector3(0, 0.05f, 0);
    }
*/

    private void OnTriggerEnter(Collider other)
    {
        if (canPush)
        {
            if(other.CompareTag("Cube")  ||  other.CompareTag("Player"))
            {
               
                foreach (GameObject first in firstGroup)
                {
                    first.GetComponent<Renderer>().material = normal;
                    first.GetComponent<Collider>().isTrigger = false;
                    
                    if (posChenger == true)
                    {
                        transform.position = transform.position + new Vector3(0, -0.05f, 0);
                        posChenger = false;
                        //button.canPush = false;
                    }
                    Timer = Timer + (int)Time.deltaTime;
                    if (Timer == (int)trimercount)
                    {
                        transform.position += new Vector3(0, 0.05f, 0);
                        posChenger = true;
                        //button.canPush = false;
                    }
                    button.canPush = true;
                }
                
                foreach (GameObject second in secondGroup)
                {
                    second.GetComponent<Renderer>().material = transparent;
                    second.GetComponent<Collider>().isTrigger = true;
                    if (posChenger == true)
                    {
                        transform.position = transform.position + new Vector3(0, -0.05f, 0);
                        posChenger = false;
                        //button.canPush = false;
                    }
                    Timer = Timer + (int)Time.deltaTime;
                    if (Timer == (int)trimercount)
                    {
                        transform.position += new Vector3(0, 0.05f, 0);
                        posChenger = true;
                        //button.canPush = true;
                    }
                    button.canPush = true;
                }
                button.GetComponent<Renderer>().material = normal;
                GetComponent<Renderer>().material = normal;
                
            }
            else
            {

                GetComponent<Renderer>().material = normal;
            }

        }
    }




}
