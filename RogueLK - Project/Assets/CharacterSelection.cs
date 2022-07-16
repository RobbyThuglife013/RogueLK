using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField]
    public GameObject[] characters;
    public int selectedCharacters = 0;
    
    public void NextCharacter()
    {
        characters[selectedCharacters].SetActive(false);
        selectedCharacters = (selectedCharacters + 1) % characters.Length;
        characters[selectedCharacters].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacters].SetActive(false);
        selectedCharacters--;
        if (selectedCharacters < 0)
        {
            selectedCharacters += characters.Length;
        }
        characters[selectedCharacters].SetActive(true);
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacters", selectedCharacters);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
