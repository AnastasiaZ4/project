using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    /// <summary>
    /// id - сцены.
    /// </summary>
    private int _idScene;

    /// <summary>
    /// Название сцены.
    /// </summary>
    public string _nextSceneName;
    //public string _nextSceneName = "Level2";


    /// <summary>
    /// Загружает следующий уровень.
    /// </summary>
    public void UploadtScene()
    {
        // int _idNextScene = _idScene + 1;
        // SceneManager.LoadScene(_idNextScene);      
        SceneManager.LoadScene(_nextSceneName);
    }

    /// <summary>
    /// Перезапускает текущий уровень.
    /// </summary>
    public void ReloadLevel()
    {
        // UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        _idScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(_idScene);
    }
}
