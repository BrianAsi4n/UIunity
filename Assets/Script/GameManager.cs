using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text numberText;
    [SerializeField] private GameObject[] livesImage;

    private int randomNumber;
    private int lives = 4;

    private void Start()
    {
        randomNumber = Random.Range(0, 10);
        Debug.Log(randomNumber);
    }
    public void EnterNumber(string number)
    {
        numberText.text = number;
    }
    public void CheckNumber()
    {
        if(numberText.text != "Enter a number")
        {
            if(randomNumber == int.Parse(numberText.text))
            {
                Debug.Log("player win");
            }
            else if (randomNumber < int.Parse(numberText.text))
            {
                Debug.Log("Lower");
                lives--;
               CheckEndGame();
            }
            else
            {
                Debug.Log("Greater");
                lives--;
                CheckEndGame() ;
            }
            if (lives >= 0 && lives < 4)
            {
                livesImage[lives].SetActive(false);
            }
        }
    }
    void CheckEndGame()
    {
        if (lives == 0)
        {
            Debug.Log("Lose");
        }
    }
}
