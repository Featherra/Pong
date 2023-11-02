using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonBot : MonoBehaviour
{
    public void PlayGame() //if u press the 1 player button it gets send to the bot scene
    {
        SceneManager.LoadScene("Bot");
    }
}
