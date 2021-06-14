using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerMovement movenent;
    public float levelRestartDelay = 2f;

    public void EndGame()
    {
        movenent.enabled = false;

        Invoke("RestartLevel", levelRestartDelay);
    }
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
