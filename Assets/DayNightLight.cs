using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity= new Vector3(.4f,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
