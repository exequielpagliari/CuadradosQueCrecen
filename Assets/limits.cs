using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limits : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print("Another object has entered the trigger");
    }
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
