using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject cubePrefab; 
    private int currentCubeCount = 0; 
    private int maxCubes = 30; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentCubeCount < maxCubes)
        {
          
            for (int i = 0; i < 1; i++) 
            {
                GameObject newCube = Instantiate(cubePrefab); 
                newCube.transform.position = transform.position + Vector3.forward * currentCubeCount; 
                currentCubeCount++; 
            }
        }
    }
}