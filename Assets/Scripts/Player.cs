using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private bool play;
    public GameObject canvas;
    public int aleatorio;
    public int Score;
    public Camera Camera;
    private int waveSquare;
    private int squaresnumber;
    private float timer;
    private float timer2;
    public GameObject Square;
    public GameObject Border;

    // Start is called before the first frame update
    void Start()
    {
        play = false;
        timer2 = 1f;
        Score = 0;
        waveSquare = 0;
        timer = 1f + Time.time;
        Ray ray = Camera.ScreenPointToRay(Input.mousePosition);

    }

    // Update is called once per frame
    void Update()
    {
        if( play == true) 
        { 
        if (squaresnumber == 0)
        {
            waveSquare = Score + 1;
            SquareInstance();
        }
        


            
                
            

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("El Mouse");
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) //&& hit.collider.gameObject == Square)
            {
                Destroy(hit.collider.gameObject);
                squaresnumber -= 1;
                Score += 1; 
                Debug.Log(hit.collider.gameObject);


            }
           // Debug.Log("Squarenumber  " +squaresnumber);
           // Debug.Log("waveSquare  " + waveSquare);
            //Debug.Log("Score  i" + Score);
        }
        {

        }

        }
    }

    public void SquareInstance()
    {       if (squaresnumber <= Score)
        {
            for (int i = 0; i < waveSquare; i++)
            {
                GameObject SquareInstantiate;
                SquareInstantiate = Instantiate(Square);
                squaresnumber += 1;
            }


        }
    }

    public void iniciar()
    {
        canvas.SetActive(false);
        play = !play;
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        canvas.SetActive(true);
    }
    
}