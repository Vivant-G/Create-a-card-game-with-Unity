using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameSaveData
{
    public List<int> completedRiddleLevels = new List<int>();
    public List<string> discoveredCards = new List<string>();
    public float musicVolume = 0.8f;
    public float sfxVolume = 0.8f;
    public bool isFullscreen = false;
    public int cardSizeIndex = 0;
}

public class GameData : MonoBehaviour
{
    public static GameData Instance { get; private set; }

    // Game data fields
    public List<int> completedRiddleLevels = new List<int>();
    public List<string> discoveredCards = new List<string>();
    public float musicVolume = 0.8f;
    public float sfxVolume = 0.8f;
    public bool isFullscreen = false;
    public int cardSizeIndex = 0;

    private void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        LoadGameData();
    }

    // Load data from PlayerPrefs
    private void LoadGameData()
    {
        string jsonData = PlayerPrefs.GetString("GameData", "{}");
        GameSaveData savedData = JsonUtility.FromJson<GameSaveData>(jsonData);

        if (savedData != null)
        {
            completedRiddleLevels = savedData.completedRiddleLevels;
            discoveredCards = savedData.discoveredCards;
            musicVolume = savedData.musicVolume;
            sfxVolume = savedData.sfxVolume;
            isFullscreen = savedData.isFullscreen;
            cardSizeIndex = savedData.cardSizeIndex;
        }
        SaveGameData();
    }

    // Save data to PlayerPrefs
    public void SaveGameData()
    {
        GameSaveData dataToSave = new GameSaveData
        {
            completedRiddleLevels = completedRiddleLevels,
            discoveredCards = discoveredCards,
            musicVolume = musicVolume,
            sfxVolume = sfxVolume,
            isFullscreen = isFullscreen,
            cardSizeIndex = cardSizeIndex
        };

        string jsonData = JsonUtility.ToJson(dataToSave, true);
        PlayerPrefs.SetString("GameData", jsonData);
        PlayerPrefs.Save();
        // ResetPlayerPrefs();
    }

    // Mark a level as completed
    public void CompleteLevel(int level)
    {
        if (!completedRiddleLevels.Contains(level))
        {
            completedRiddleLevels.Add(level);
            SaveGameData();
        }
    }

    public bool HasCompletedLevel(int level)
    {
        return completedRiddleLevels.Contains(level);
    }

    public void discoverCard(string cardName)
    {
        if (!discoveredCards.Contains(cardName))
        {
            discoveredCards.Add(cardName);
            SaveGameData();
        }
    }

    public bool HasDiscoveredCard(string cardName)
    {
        return discoveredCards.Contains(cardName);
    }
    private void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }

    public void ApplyLoadedSettings()
    {
        AudioManager.Instance.SetMusicVolume(musicVolume);
        AudioManager.Instance.SetSFXVolume(sfxVolume);

        Screen.fullScreen = isFullscreen;
    }
}