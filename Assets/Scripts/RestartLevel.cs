using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RestartLevel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI GameOverScoreText;
    [SerializeField] TextMeshProUGUI GameOverAppleText;
    [SerializeField] TextMeshProUGUI GameOverBananaText;
    [SerializeField] TextMeshProUGUI GameOverCherryText;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        PlayerPrefs.SetInt("TotalApples", PlayerPrefs.GetInt("TotalApples") + PlayerPrefs.GetInt("Apples"));
        PlayerPrefs.SetInt("TotalBananas", PlayerPrefs.GetInt("TotalBananas") +PlayerPrefs.GetInt("Bananas"));
        PlayerPrefs.SetInt("TotalCherries", PlayerPrefs.GetInt("TotalCherries") +PlayerPrefs.GetInt("Cherries"));
    }

    // Update is called once per frame
    void Update()
    {
        GameOverScoreText.text = PlayerPrefs.GetInt("Score").ToString();
        GameOverAppleText.text = PlayerPrefs.GetInt("Apples").ToString();
        GameOverBananaText.text = PlayerPrefs.GetInt("Bananas").ToString();
        GameOverCherryText.text = PlayerPrefs.GetInt("Cherries").ToString();

        if(Input.GetKeyDown(KeyCode.A))
        {
            FindObjectOfType<SceneLoader>().GamePlayScene();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<SceneLoader>().MainMenu();
        }
    }
}
