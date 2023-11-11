using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float cooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            Instantiate(animalPrefabs[0], new Vector3(18, 0, 0), animalPrefabs[0].transform.rotation);
            cooldown = 2;
        }

        if (cooldown >= 0)
        {
            cooldown -= Time.deltaTime;
        }
        
    }
}
