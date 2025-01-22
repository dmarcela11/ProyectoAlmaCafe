using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
