using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCube : MonoBehaviour
{
    [SerializeField] private GameObject Arrow = null;
    [SerializeField] private AudioSource Interval = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        Arrow.SetActive(true);

        if (Input.GetMouseButtonDown(0))
        {
            Interval.Play();
        }

    }

    private void OnMouseExit()
    {
        Arrow.SetActive(false);
    }


}
