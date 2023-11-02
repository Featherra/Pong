using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnderSea : MonoBehaviour
{
    public void Playgame() // if u press the under the sea game mode button on the menu it gets send to the UndertheSea scene
    {
        SceneManager.LoadScene("UndertheSea");   
    }

        
}
