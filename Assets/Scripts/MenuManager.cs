using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI bestScore;
    public TextMeshProUGUI usernameTextMesh;

    // Start is called before the first frame update
    void Start()
    {
        DataPersistence.Instance.LoadScore();
        bestScore.SetText($"Best Score : {DataPersistence.Instance.username} {DataPersistence.Instance.score}");
    }

    public void StartNewGame()
    {
        DataPersistence.Instance.username = usernameTextMesh.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
