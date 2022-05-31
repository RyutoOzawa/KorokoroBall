using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject exitObj;
    private void OnTriggerEnter(Collider other)
    {
        if(exitObj != null)
        {
            other.transform.position = exitObj.transform.position;
        }
    }
}
