using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FruitsCounter : MonoBehaviour
{
    float NoOfApples = 0f;
    float NoOfBananas = 0f;
    float NoOfCherries = 0f;

    [SerializeField] TextMeshProUGUI AppleText;
    [SerializeField] TextMeshProUGUI BananaText;
    [SerializeField] TextMeshProUGUI CherryText;


    public void IncrementApples()
    {
        NoOfApples =NoOfApples + 0.6f;
    }

    public void IncrementBananas()
    {
        NoOfBananas = NoOfBananas + 0.6f;
    }

    public void IncrementCherries()
    {
        NoOfCherries = NoOfCherries + 0.6f;
    }

    private void Update()
    {
        int Apples = (int)NoOfApples;
        PlayerPrefs.SetInt("Apples", Apples);
        AppleText.text = Apples.ToString();
        int bananas = (int)NoOfBananas;
        PlayerPrefs.SetInt("Bananas", bananas);
        BananaText.text = bananas.ToString();
        int Cherries = (int)NoOfCherries;
        PlayerPrefs.SetInt("Cherries", Cherries);
        CherryText.text = Cherries.ToString();
    }
}