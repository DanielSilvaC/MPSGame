using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teste : MonoBehaviour
{

	public void Testando(){
		#if UNITY_EDITOR
        if (UnityEditor.EditorUtility.DisplayDialog("Sair", "Você deseja mesmo sair?", "Sim", "Não"))
        {
			Application.Quit();
        }
        else
        {
			DontDestroyOnLoad(gameObject);
            //SceneManager.LoadScene(0);
        }
		#endif
	}

}