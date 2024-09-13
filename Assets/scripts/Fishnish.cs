using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishnish : MonoBehaviour
{
    public bool finish = false;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        finish = true;
    }
}
