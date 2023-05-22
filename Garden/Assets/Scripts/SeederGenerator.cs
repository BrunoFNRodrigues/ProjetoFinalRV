using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SeederGenerator : MonoBehaviour
{
    public GameObject seedObject;
    public SteamVR_Input_Sources inputSourceRight,inputSourceLeft;
    public SteamVR_Action_Boolean spawnAction;

    public bool spawnFlag = false; 
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other){
        print(other.tag);
        if (other.tag == "Player"){
            print("A");
            
            if ( (spawnAction.GetStateDown(inputSourceRight) || (spawnAction.GetStateDown(inputSourceLeft)) ) && !spawnFlag){
                print("SPAWNED");
                Instantiate(seedObject, other.transform.position, other.transform.rotation);
                spawnFlag = true;
            }
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        spawnFlag  = false;
    }
}
