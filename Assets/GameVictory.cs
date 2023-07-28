using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameVictory : MonoBehaviour
{
    public void GoToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
