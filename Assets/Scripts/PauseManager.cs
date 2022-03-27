using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;
    bool IsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ResumeButton()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
        Cursor.visible = false;
        IsPaused = false;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
            Cursor.visible = true;
            IsPaused = true;
        }
        
    }
}
