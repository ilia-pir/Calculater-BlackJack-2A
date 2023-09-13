using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
    
public class BlackJack : MonoBehaviour
{
    public TMP_Text playerText;
    public TMP_Text dealerText;
    public TMP_Text OutcomeText;
    
    private int playerScore = 0;
    private int dealerScore = 0;

    private void Start()
    {
        DealerDrawCard();
    }
    
private void DealerDrawCard()
    {
        dealerScore = Random.Range(17, 27);
    }
    public void DrawCard()
    {
        int drawnCard = Random.Range(1, 11);
        playerScore = playerScore + drawnCard;
        
        playerText.text = "Player:" + playerScore.ToString();
        
    }

    public void CompareValues()
    {
        dealerText.text = "Dealer: " + dealerScore.ToString();
        
        if (playerScore > 21)// Player has more than 21, he loses.
        {
            Lose();
        }
        else if (playerScore == 21)// Player has 21 = automatic win
        {
            Win();
        }
        else if (dealerScore > 21 )// Dealer has more than 21, he loses.
        {
            Win();
        }
        else if (dealerScore < playerScore) // Player has more.
        {
            Win();
        }
        else if (dealerScore > playerScore)// Dealer has more.
        {
            Lose();
        }
        else if (dealerScore == playerScore)// Same number
        {
            Debug.Log(message:"TIE");
        }
    }

    private void Win()
    {
        OutcomeText.text = "You win!";
    }

    private void Lose()
    {
        OutcomeText.text = "You lose";
    }
}

