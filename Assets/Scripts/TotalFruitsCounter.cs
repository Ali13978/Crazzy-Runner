using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalFruitsCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TotalApples;
    [SerializeField] TextMeshProUGUI TotalBananas;
    [SerializeField] TextMeshProUGUI TotalCherries;
    [SerializeField] int NewValueOfApples = 0;
    [SerializeField] bool CanChangeValueOfApples = false;
    [SerializeField] int NewValueOfBananas = 0;
    [SerializeField] bool CanChangeValueOfBananas = false;
    [SerializeField] int NewValueOfCherries = 0;
    [SerializeField] bool CanChangeValueOfCherries = false;
    // Start is called before the first frame update
    void Start()
    {
        TotalApples.text = PlayerPrefs.GetInt("TotalApples").ToString();
        TotalBananas.text = PlayerPrefs.GetInt("TotalBananas").ToString();
        TotalCherries.text = PlayerPrefs.GetInt("TotalCherries").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (CanChangeValueOfApples)
        {
            PlayerPrefs.SetInt("TotalApples", NewValueOfApples);
        }
        TotalApples.text = PlayerPrefs.GetInt("TotalApples").ToString();
        if (CanChangeValueOfBananas)
        {
            PlayerPrefs.SetInt("TotalBananas",NewValueOfBananas);
        }
        TotalBananas.text = PlayerPrefs.GetInt("TotalBananas").ToString();
        if (CanChangeValueOfCherries)
        {
            PlayerPrefs.SetInt("TotalCherries", NewValueOfCherries);
        }
        TotalCherries.text = PlayerPrefs.GetInt("TotalCherries").ToString();
    }
}
