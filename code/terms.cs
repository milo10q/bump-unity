using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class terms : MonoBehaviour
{
    public GameObject term;
    public GameObject tick;
    public GameObject signup;
    public bool accepted = false;

    public void ticked()
    {
        accepted = !accepted;
        tick.SetActive(!tick.activeSelf);
    }

    public void readTerms()
    {
        term.SetActive(!term.activeSelf);
        signup.SetActive(!signup.activeSelf);
    }
}
 