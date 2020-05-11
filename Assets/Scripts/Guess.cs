using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Guess : MonoBehaviour
{
    private static int number = 1, guessedNumber = 0;
    public Text guessedText;
    public void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            guessedText.text = guessedNumber.ToString();
            
        }
    }

    public void PlayGame()
    {
        number = 1;
        guessedNumber = 0;
        SceneManager.LoadScene(1);
    }
    public void NextScene()
    {
        Debug.Log(guessedNumber);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }


    public void ItIs()
    {
        guessedNumber += number;
        number *= 2;
        NextScene();
    }

    public void ItIsNot()
    {
        number *= 2;
        NextScene();
    }

    
}
