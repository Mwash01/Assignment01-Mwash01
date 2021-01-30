using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public InputField playerName;
    public string userName;
    public Text printName;

    public void PrintName()
    {
        userName = playerName.text;
        printName.text = "Player Name: " + userName;
    }
}
