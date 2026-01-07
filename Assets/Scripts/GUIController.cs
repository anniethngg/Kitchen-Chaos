using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{
    Button newGameButton;
    Button closeButton;
    public TMP_InputField nameInput;

    public String username;
    public PlayerController playerController;
    
    public void Start()
    {
        playerController = FindFirstObjectByType<PlayerController>();
    }

    public void SaveName()
    {
        username = nameInput.text;
        nameInput.text = "";

        Debug.Log("Name saved: " + username);
    }

    public void NewGame()
    {
        if (username != "" && username != null)
        {
            playerController.escapeMenu.SetActive(false);
            playerController.Reset();
        }
    }
}