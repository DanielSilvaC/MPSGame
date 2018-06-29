using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcoes : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Voltar()
	{
		DontDestroyOnLoad(gameObject);

		SceneManager.LoadScene("Menu");
	}

    public void VoltarDocente()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("IniciarDocente");
    }

    public void VoltarSelecionarPerfil()
	{
		DontDestroyOnLoad(gameObject);

		SceneManager.LoadScene("Selecionar Perfil");
	}

    public void Sobre()
	{
		DontDestroyOnLoad(gameObject);

		SceneManager.LoadScene("Sobre");
	}

    public void SobreDocente()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("SobreDocente");
    }

    public void Discente()
	{
		DontDestroyOnLoad(gameObject);

		SceneManager.LoadScene("Discente");
	}

	public void Docente ()
	{
		DontDestroyOnLoad(gameObject);
		SceneManager.LoadScene("Docente");
	}

	public void Persistent ()
	{
		DontDestroyOnLoad(gameObject);
		SceneManager.LoadScene("Persistent");
	}

	public void Nivel ()
	{
		DontDestroyOnLoad(gameObject);
		SceneManager.LoadScene("NivelQuiz");
	}

    public void Menu()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Menu");
    }

    public void Opcao()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Opcoes");
    }

    public void Ilustracao()
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

    public void Proximo2()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ajuda2");
    }

    public void Proximo3()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ajuda3");
    }

    public void Proximo4()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ajuda4");
    }

    public void Proximo5()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ajuda5");
    }

    public void CarregarAjuda()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Ajuda");
    }

    public void CarregarAjudaDocente()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("AjudaDocente");
    }

    public void CarregarInserirPergunta()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("InserirPergunta");
    }

    public void CarregarIniciarDocente()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("IniciarDocente");
    }
}

