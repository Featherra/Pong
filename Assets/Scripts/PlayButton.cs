using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    public void PlayGame ()  // if u press the 2 players button it gets send to the collision scene
    {
        SceneManager.LoadScene("collision");
    }
}
