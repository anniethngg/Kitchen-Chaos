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

    String username;

    public void SaveName()
    {
        username = nameInput.text;
        nameInput.text = "";

        Debug.Log("Name saved: " + username);
    }
}
