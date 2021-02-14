using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public bool isBatting;

    private void Awake()
    {
        isBatting = false;
    }
    void Update()
    {
        if(isBatting)
        {
            this.transform.position = new Vector3(Random.Range(3, 100), -.5f, Random.Range(3, 100));
            isBatting = false;
        }
    }
}
