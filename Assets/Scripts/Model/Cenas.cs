using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CarregarIlustracao()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ilustracao");
    }

    public void Ilustracao2()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ilustracao2");
    }

    public void Ilustracao3()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ilustracao3");
    }

    public void Ilustracao4()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ilustracao4");
    }

    public void Ilustracao5()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ilustracao5");
    }

    public void Ilustracao6()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ilustracao6");
    }


    public void Ilustracao7()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ilustracao7");
    }
}
