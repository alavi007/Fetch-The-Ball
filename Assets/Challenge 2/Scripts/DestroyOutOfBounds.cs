using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{


    private float lowerBound = 0;
    private float sideBound = -25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        
        else if (transform.position.x < sideBound)
        {
            Destroy(gameObject);
        }
    }
}
