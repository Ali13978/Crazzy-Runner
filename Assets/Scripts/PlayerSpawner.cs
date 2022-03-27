using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] Players;
    int SelectedPlayerIndex;
    // Start is called before the first frame update
    void Start()
    {
        SelectedPlayerIndex = PlayerPrefs.GetInt("SelectedPlayer");
        Instantiate(Players[SelectedPlayerIndex], new Vector3(4.65f, 1.19f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
