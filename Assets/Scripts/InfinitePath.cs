using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitePath : MonoBehaviour
{
    [SerializeField] List <GameObject> Terrains;
    [SerializeField] float TerrainSpawnPos = 36.57f;

    bool Terrain4Bought = true;
    Vector2 MyTransform;

    int RayIndex;
    float CurrentPos;
    float TargetPos;
    bool firsttime = true;
    // Start is called before the first frame update
    void Start()
    {
        MyTransform = GetComponent<Transform>().position;
        CurrentPos = MyTransform.x;
        TargetPos = CurrentPos - 43f;
        RayIndex = Terrains.Count;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPath();
    }

    private void SpawnPath()
    {
        CurrentPos = GetComponent<Transform>().position.x;
        if(CurrentPos <= TargetPos)
        {
            TargetPos = TargetPos - 43f;
            {
                int NextPath = Random.Range(0, RayIndex);
                GameObject ABC = Terrains[NextPath];
                if (firsttime)
                {
                    Instantiate(ABC, new Vector2(TerrainSpawnPos, 0), Quaternion.identity , this.transform);
                    firsttime = false;
                }
                else
                {
                    TerrainSpawnPos = TerrainSpawnPos + 37.035f;
                    Instantiate(ABC, new Vector2(TerrainSpawnPos, 0), Quaternion.identity , this.transform) ;
                }
            }
        }
    } 
}
