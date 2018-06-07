using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class DataController : MonoBehaviour
{

    public RoundData[] todasAsRodadas;

    private int rodadaIndex;
    private int playerHighScore;

    private string gameDataFileName = "data.json";

    // Use this for initialization
    void Start()
    {

        DontDestroyOnLoad(gameObject);

        LoadGameData();

        SceneManager.LoadScene("NivelQuiz");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetRoundData(int round)
    {
        rodadaIndex = round;
    }

    public RoundData GetCurrentRoundData()
    {
        return todasAsRodadas[rodadaIndex];
    }

    private void LoadGameData()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);
            todasAsRodadas = loadedData.todasAsRodadas;

        }
        else
        {
            Debug.LogError("Não foi possível carregar dados!");
        }
    }

    public void EnviarNovoHighScore(int newScore)
    {
        if (newScore > playerHighScore)
        {
            playerHighScore = newScore;
            SavePlayerProgress();
        }
    }

    public int GetHighScore()
    {
        return playerHighScore;
    }

    private void LoadPlayerProgress()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            playerHighScore = PlayerPrefs.GetInt("HighScore");
        }
    }

    private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("HighScore", playerHighScore);
    }
}
