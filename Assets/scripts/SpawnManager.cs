using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject min3Prefab;
    [SerializeField] private GameObject Maj3Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(min3Prefab);

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Instantiate(Maj3Prefab);
            }
    }
}
