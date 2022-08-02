using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Canvas;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        GameObject CameraInstace;
        CameraInstace = Instantiate(Camera);
        GameObject PlayerInstace;
        PlayerInstace = Instantiate(Player);
        GameObject CanvasInstance;
        CanvasInstance = Instantiate(Canvas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
