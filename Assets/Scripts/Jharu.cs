using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jharu : MonoBehaviour
{
    [SerializeField] int TimeTakenToDelete = 60;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeletePath());
    }

    private IEnumerator DeletePath()
    {
        yield return new WaitForSeconds(TimeTakenToDelete);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
