using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class CrudPerguntas : MonoBehaviour {

    //[SerializeField]
    public InputField nivel;
    public InputField pergunta;
    public InputField respostaA;
    public InputField respostaB;
    public InputField respostaC;
    public InputField respostaD;

    public static string recebeNivel;
    public static string recebePergunta;
    public static string recebeRespostaA;
    public static string recebeRespostaB;
    public static string recebeRespostaC;
    public static string recebeRespostaD;

    public string[] cfg;

    public string linha;

    public Toggle togle1;
    public Toggle togle2;
    public Toggle togle3;
    public Toggle togle4;

    public string resposta;


    // Use this for initialization
    void Start()
    {
        //pergunta.text = "teste";
        /*if (recebePergunta != null)
        {
            pergunta.text = recebePergunta;
        }*/

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*void Reset()
    {
        cfg = new string[6]; // Declarando o tamanho da Array, aqui deve ser colocado o tamanho de configurações que seu arquivo deve ter. No caso deste exemplo é 4.
    }

    public void Awake()
    {
        Reset();

        /*if (recebePergunta != null)
        {
            pergunta.text = recebePergunta;
        }
        StreamReader sr = new StreamReader(Application.dataPath + "/StreamingAssets/Dados.txt");
        linha = sr.ReadLine();
        recebePergunta = PlayerPrefs.GetString("perguntaTexto", linha);
        pergunta.text = recebePergunta;
        sr.Close();
        int t = 0; 

        if (recebeNivel != null && recebePergunta != null && recebeRespostaA != null &&
            recebeRespostaB != null && recebeRespostaC != null && recebeRespostaD != null)
        {
            nivel.text = recebeNivel;
            pergunta.text = recebePergunta;
            respostaA.text = recebeRespostaA;
            respostaB.text = recebeRespostaB;
            respostaC.text = recebeRespostaC;
            respostaD.text = recebeRespostaD;
        }

        StreamReader sr = new StreamReader(Application.dataPath + "/StreamingAssets/Dados.txt");

        linha = sr.ReadLine();

        while (linha != null)
        {
            cfg[t] = linha;
            recebeNivel = PlayerPrefs.GetString("nivelTexto", cfg[0]);
            nivel.text = recebeNivel;
            recebePergunta = PlayerPrefs.GetString("perguntaTexto", cfg[1]);
            pergunta.text = recebePergunta;
            recebeRespostaA = PlayerPrefs.GetString("respostaATexto", cfg[2]);
            respostaA.text = recebeRespostaA;
            recebeRespostaB = PlayerPrefs.GetString("respostaBTexto", cfg[3]);
            respostaB.text = recebeRespostaB;
            recebeRespostaC = PlayerPrefs.GetString("respostaCTexto", cfg[4]);
            respostaC.text = recebeRespostaC;
            recebeRespostaD = PlayerPrefs.GetString("respostaDTexto", cfg[5]);
            respostaD.text = recebeRespostaD;
            t++;
           
        }
        sr.Close();
       

    }

    /*public void SetPerguntaTexto(string text)
    {
        recebePergunta = text;
        PlayerPrefs.SetString("perguntaTexto", recebePergunta);
    }*/

    public void Teste()
    {
        StreamReader sr = new StreamReader(Application.dataPath + "/StreamingAssets/Dados.txt");


        recebeNivel = sr.ReadLine();
        recebePergunta = sr.ReadLine();
        recebeRespostaA = sr.ReadLine();
        recebeRespostaB = sr.ReadLine();
        recebeRespostaC = sr.ReadLine();
        recebeRespostaD = sr.ReadLine();
        resposta = sr.ReadLine();
        Debug.Log("" +resposta);

        if (recebeNivel != null && recebePergunta != null && recebeRespostaA != null &&
            recebeRespostaB != null && recebeRespostaC != null && recebeRespostaD != null)
        {
            nivel.text = recebeNivel;
            pergunta.text = recebePergunta;
            respostaA.text = recebeRespostaA;
            respostaB.text = recebeRespostaB;
            respostaC.text = recebeRespostaC;
            respostaD.text = recebeRespostaD;
        }
        

        /*nivel.text = recebeNivel;
        pergunta.text = recebePergunta;
        respostaA.text = recebeRespostaA;
        respostaB.text = recebeRespostaB;
        respostaC.text = recebeRespostaC;
        respostaD.text = recebeRespostaD;


         Debug.Log("" + recebeNivel);
         Debug.Log("" + recebePergunta);
         Debug.Log("" + recebeRespostaA);
         Debug.Log("" + recebeRespostaB);
         Debug.Log("" + recebeRespostaC);
         Debug.Log("" + recebeRespostaD);
         */
        sr.Close();
        if (resposta == "1")
        {
            togle1.isOn = true;
        }
        if (resposta == "2")
        {
            togle2.isOn = true;
        }
        if (resposta == "3")
        {
            togle3.isOn = true;
        }
        if (resposta == "4")
        {
            togle4.isOn = true;
        }


    }

    public void InserindoDados()
    {
        StreamWriter sw = new StreamWriter(Application.dataPath + "/StreamingAssets/Dados.txt");
        
        recebeNivel = nivel.text;
        recebePergunta = pergunta.text;
        recebeRespostaA = respostaA.text;
        recebeRespostaB = respostaB.text;
        recebeRespostaC = respostaC.text;
        recebeRespostaD = respostaD.text;

        Debug.Log("" + recebeNivel);
        Debug.Log("" + recebePergunta);
        Debug.Log("" + recebeRespostaA);
        Debug.Log("" + recebeRespostaB);
        Debug.Log("" + recebeRespostaC);
        Debug.Log("" + recebeRespostaD);

        sw.WriteLine("" + recebeNivel);
        sw.WriteLine("" + recebePergunta);
        sw.WriteLine("" +recebeRespostaA);
        sw.WriteLine("" + recebeRespostaB);
        sw.WriteLine("" + recebeRespostaC);
        sw.WriteLine("" + recebeRespostaD);

       

        if (togle1.isOn)
        {
            resposta = "1";
            sw.WriteLine("" +1);
            Debug.Log("" + resposta);
        }
        if (togle2.isOn)
        {
            resposta = "2";
            sw.WriteLine("" + 2);
        }
        if (togle3.isOn)
        {
            resposta = "3";
            sw.WriteLine("" + 3);
        }
        if (togle4.isOn)
        {
            resposta = "4";
            sw.WriteLine("" + 4);
        }
        sw.Close();
        nivel.text = "";
        pergunta.text = "";
        respostaA.text = "";
        respostaB.text = "";
        respostaC.text = "";
        respostaD.text = "";
        togle1.isOn = false;
        togle2.isOn = false;
        togle3.isOn = false;
        togle4.isOn = false;
    }

    public void ExcluindoDados()
    {
        togle1.isOn = false;
        togle2.isOn = false;
        togle3.isOn = false;
        togle4.isOn = false;
        nivel.text = "";
        pergunta.text = "";
        respostaA.text = "";
        respostaB.text = "";
        respostaC.text = "";
        respostaD.text = "";
        StreamWriter sw = new StreamWriter(Application.dataPath + "/StreamingAssets/Dados.txt");
        sw.WriteLine("");
        sw.WriteLine("");
        sw.WriteLine("");
        sw.WriteLine("");
        sw.WriteLine("");
        sw.WriteLine("");
       
        sw.Close();
    }
    
}
