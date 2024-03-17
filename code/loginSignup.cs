using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class loginSignup : MonoBehaviour
{
    public GameObject signup;
    public GameObject login;
    public GameObject home;
    public GameObject error;
    public TextMeshProUGUI UIPassword;
    public TextMeshProUGUI UIUsername;
    public string username;
    public string password;

    public void Login()
    {
        signup.SetActive(false);
        login.SetActive(true);
    }

    public void Signup()
    {
        signup.SetActive(true);
        login.SetActive(false);
    }

    public void homePage()
    {
        home.SetActive(true);
        login.SetActive(false);
    }

    public void CheckPassAndUser()
    {
        password = UIPassword.GetParsedText().Replace(" ","");
        username = UIUsername.GetParsedText().Replace(" ","");
        
        if (username == "Lillylovesart" && password == "Example123")
        {
            error.SetActive(false);
            login.SetActive(false);
            home.SetActive(true);
        }
        else
        {
            error.SetActive(true);
        }
        
    }
}
