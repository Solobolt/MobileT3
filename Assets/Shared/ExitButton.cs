using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ExitButton : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GoToMainMenu();
        }
    }

	public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
