﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginController : MonoBehaviour
{

    private const string Login = "Daniel";
    private const string Senha = "102030";

    [SerializeField]
    private InputField nome = null;
    [SerializeField]
    private InputField senha = null;
    [SerializeField]
    private Text feedbacking = null;
    [SerializeField]
    private Toggle rememberData = null;


    // Use this for initialization
    void Start()
    {
        if(PlayerPrefs.HasKey("remember") && PlayerPrefs.GetInt("remember") == 1)
        {
            nome.text = PlayerPrefs.GetString("rememberLogin");
            senha.text = PlayerPrefs.GetString("rememberPass");
        }
    }



 
    public void FazerLogin()
    {

        string usuario = nome.text;
        string pass = senha.text;

        if (rememberData.isOn)
        {
            PlayerPrefs.SetInt("remember", 1);
            PlayerPrefs.SetString("rememberLogin", usuario);
            PlayerPrefs.SetString("rememberPass", pass);
        }

        if (usuario == Login && pass == Senha)
        {
            SceneManager.LoadScene("Menu");
        }
        else{
            feedbacking.CrossFadeAlpha(100f, 0f, false);
            feedbacking.color = Color.red;
            feedbacking.text = "Usuário ou senha inválidos";
            feedbacking.CrossFadeAlpha(0f, 2f, false);
            nome.text = "";
            senha.text = "";
        }


    }
}