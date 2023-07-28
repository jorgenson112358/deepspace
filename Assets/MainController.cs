using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel")) {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void MissionVictory() {
        SceneManager.LoadScene("MissionVictory");
    }
}
