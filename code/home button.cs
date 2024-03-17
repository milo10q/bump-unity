using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homebutton : MonoBehaviour
{
    public GameObject homepage;
    public GameObject login;
    public GameObject signup;
    public GameObject forums;
    public GameObject vitals;
    public GameObject profile;
    public GameObject externals;
    

    public void GoHome()
    {
        homepage.SetActive(true);
        login.SetActive(false);
        signup.SetActive(false);
        forums.SetActive(false);
        vitals.SetActive(false);
        profile.SetActive(false);
        externals.SetActive(false);
        
    }

    public void GoProfile()
    {
        homepage.SetActive(false);
        login.SetActive(false);
        signup.SetActive(false);
        forums.SetActive(false);
        vitals.SetActive(false);
        profile.SetActive(true);
        externals.SetActive(false);
        
    }
    
    public void GoVitals()
    {
        homepage.SetActive(false);
        login.SetActive(false);
        signup.SetActive(false);
        forums.SetActive(false);
        vitals.SetActive(true);
        profile.SetActive(false);
        externals.SetActive(false);
        
    }
    
    public void GoForums()
    {
        homepage.SetActive(false);
        login.SetActive(false);
        signup.SetActive(false);
        forums.SetActive(true);
        vitals.SetActive(false);
        profile.SetActive(false);
        externals.SetActive(false);
        
    }

    public void GoExternals()
    {
        homepage.SetActive(false);
        login.SetActive(false);
        signup.SetActive(false);
        forums.SetActive(false);
        vitals.SetActive(false);
        profile.SetActive(false);
        externals.SetActive(true);
        
    }
    

}
