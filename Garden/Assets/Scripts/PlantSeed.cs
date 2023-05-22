using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSeed : MonoBehaviour
{
    public List<GameObject> spawners = new List<GameObject>();
    public GameObject plant;

    private void OnTriggerEnter(Collider other){
        if (other.tag == "Seed" && spawners.Count != 0){
            Instantiate(plant, spawners[0].transform.position, spawners[0].transform.rotation);
            Destroy(other.gameObject);
            spawners.RemoveAt(0);
        }       
    }


}
