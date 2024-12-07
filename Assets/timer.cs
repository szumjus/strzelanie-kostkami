using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cube; 
    void Start()
    {
      
        for (int i = 0; i < cube.Length; i+=2)
        {
            cube[i].transform.position += Vector3.up * 10;
        }
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
