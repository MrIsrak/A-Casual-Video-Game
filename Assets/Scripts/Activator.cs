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
    bool posChenger2 = true;
    int Timer;
    public int trimercount;

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
                    //1
                    /*
                    if (posChenger == true)
                    {
                        transform.position -= new Vector3(0, 0.05f, 0);
                        posChenger = false;
                        button.canPush = false;
                    }
                    Timer = Timer + (int)Time.deltaTime;
                    if (Timer == (int)trimercount)
                    {
                        transform.position += new Vector3(0, 0.05f, 0);
                        posChenger = true;
                        //button.canPush = true;
                        //
                    }
                    */
                    button.canPush = true;
                    button.GetComponent<Renderer>().material = transparent;
                }
                
                foreach (GameObject second in secondGroup)
                {
                    //2
                    second.GetComponent<Renderer>().material = transparent;
                    second.GetComponent<Collider>().isTrigger = true;
                    button.GetComponent<Renderer>().material = normal;
                    if (posChenger2 == true)
                    {
                        posChenger2 = false;
                        button.canPush = true;
                        GameObject.Find("button 1").transform.position = new Vector3(5.02f, 0.70f, -5.75f);
                        
                        GameObject.Find("button 2").transform.position = new Vector3(-6.5f, 0.70f, -5.75f);

                    }
                    //System.Threading.Thread.Sleep(10);
                    if (posChenger2 == false)
                    {
                        posChenger2 = true;
                        button.canPush = true;
                        GameObject.Find("button 1").transform.position = new Vector3(5.02f, 0.75f, -5.75f);
                        GameObject.Find("button 2").transform.position = new Vector3(-6.5f, 0.75f, -5.75f);

                        //
                    }
                    posChenger2 = true;
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
