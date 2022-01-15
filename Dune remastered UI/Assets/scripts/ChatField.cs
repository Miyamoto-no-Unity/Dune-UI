using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatField : MonoBehaviour
{

public InputField inputField; 
public Text chatField; 
public string nickName;

public string opponentName;

public void ChangeText()
{
    chatField.text += "\n" +"<color=blue>"+nickName + "</color>: " + inputField.text;
}

public void Answer()
{
    string answer = "";
    int answerNum = Random.Range(0,3);

    switch(answerNum)
    {
        case 0:
        answer = "hello!";
        break;
        case 1:
        answer = "glhf";
        break;
        case 2:
        answer = "gg";
        break;
    }

    chatField.text += "\n" +"<color=red>"+opponentName + "</color>: " + answer;
}
}











