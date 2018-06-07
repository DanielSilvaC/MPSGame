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

	public void Discente()
	{
		DontDestroyOnLoad(gameObject);

		SceneManager.LoadScene("Discente");
	}

	public void Docente ()
	{
		DontDestroyOnLoad(gameObject);
		SceneManager.LoadScene("InserirPergunta");
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
}
