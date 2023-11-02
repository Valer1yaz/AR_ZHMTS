using System;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;
using Unity.VisualScripting;

public class MagicButton : MonoBehaviour
{
    public event Action OnButtonClicked;

    public GameObject Cube;
    public Material first;
    public Material second;
    public Material third;

    public void Update()
    {
        if (Cube.GetComponent<Renderer>().material = first) 
        {
            Cube.GetComponent<Renderer>().material = second;
        }
        else if (Cube.GetComponent<Renderer>().material = second)
        {
            Cube.GetComponent<Renderer>().material = third;
        }
        else
        {
            Cube.GetComponent<Renderer>().material = first;
        }

    }
   
}