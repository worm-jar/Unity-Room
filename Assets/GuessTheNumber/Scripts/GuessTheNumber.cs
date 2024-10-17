using TMPro;
using UnityEditor;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame();
    } 
    public void Try()
    {
        if(int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber > 100 || playerNumber < 1)
            {
                messageText.text = "Please input a number between 1 and 100";
            }
            if (playerNumber > randomNumber)
            {
                messageText.text = "too high!";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "too low!";
            }
            else
            {
                messageText.text = "correct!";
            }
        }
        else
        { 
            messageText.text = "Please input a number";
        }
        numberInput.text = "";
    }
    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log(randomNumber);
        messageText.text = "Guess the number...";
    }
}
