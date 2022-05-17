using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[ÉãÅI");

        clearText.SetActive(true);
        nextButton.SetActive(true);
    }
}
