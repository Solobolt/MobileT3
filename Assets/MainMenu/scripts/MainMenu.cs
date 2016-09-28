using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public void loadSceneNamed(string name)
    { 
        SceneManager.LoadScene(name);
    }

}
