using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] GameObject AllTerrains;
    [SerializeField] TextMeshProUGUI ScoreText;
    int Score;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    private void CountScore()
    {
        Score = (-1 ) * ((int)AllTerrains.GetComponent<Transform>().position.x);
        PlayerPrefs.SetInt("Score", Score);
        ScoreText.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        CountScore();
    }
}
