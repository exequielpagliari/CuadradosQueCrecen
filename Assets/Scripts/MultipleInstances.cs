using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleInstances : MonoBehaviour
{
    public Sprite Square;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Sprite SquareInstantiate;
            SquareInstantiate = Instantiate(Square);
        }
    }
}
