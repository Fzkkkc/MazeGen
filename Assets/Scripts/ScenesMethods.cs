using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesMethods : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}