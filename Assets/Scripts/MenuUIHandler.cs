using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public string playerName;
    //public TextMeshProUGUI playerNameInput;
    public TMP_InputField playerNameInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        
        playerName = playerNameInput.text;
        StaticData.valueToKeep = playerName;
        SceneManager.LoadScene(1);
        
    }

    public void Exit()
    {
        MainManager.instance.SaveScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
