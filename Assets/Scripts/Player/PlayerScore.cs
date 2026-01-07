using TMPro;
using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    GUIController guiController;
    PlayerController playerController;

    // String currentName = "";
    TextMeshProUGUI nameInput;
    Button newGameButton;

    void Start()
    {
        scoreText.text = "Score: " + score.ToString();

        guiController = FindFirstObjectByType<GUIController>();
        playerController = FindFirstObjectByType<PlayerController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            score += 1;
            scoreText.text = "Score: " + score.ToString();
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            // Save the score to scores.csv
            string filePath = "Assets/Scripts/Player/scores.csv";
            string text = File.ReadAllText(filePath);

            File.WriteAllText(filePath, text + Environment.NewLine + guiController.username + "," + score.ToString());
            Debug.Log("Score saved to " + filePath);

            playerController.Reset();
            playerController.escapeMenu.SetActive(true);
        }
    }
}