using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareAction : MonoBehaviour
{
    public GameObject player;
    private float Xalea;
    private float Yalea;
    public Vector3 Arista1;
    public Vector3 Arista2;
    public Vector3 Arista3;
    public Vector3 Arista4;
    // Start is called before the first frame update
    void Start()
    {
        Yalea = Random.Range(3.5f, -3.5f);
        Xalea = Random.Range(-7.5f, 7.5f);
        transform.localScale = new Vector3(0, 0, 0);
        transform.position = new Vector3(Xalea, Yalea, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(+0.005f, +0.005f, 0);
        Arista1 = (new Vector3(0.5f * transform.localScale.x  + Xalea, 0.5f * transform.localScale.y + Yalea, 0));
        Arista2 = (new Vector3(0.5f * transform.localScale.x + Xalea, -0.5f * transform.localScale.y + Yalea, 0));
        Arista3 = (new Vector3(-0.5f * transform.localScale.x + Xalea, -0.5f * transform.localScale.y  + Yalea, 0));
        Arista4 = (new Vector3(-0.5f * transform.localScale.x + Xalea, 0.5f * transform.localScale.y + Yalea, 0));
       // Debug.Log("Arista1" + Arista1);
       // Debug.Log("Arista2" + Arista2);
        //Debug.Log("Arista3" + Arista3);
        //Debug.Log("Arista4" + Arista4);

        if (Arista1.x > 10 || Arista1.x < -10 || Arista1.y > 5 || Arista1.y < -5)
        {
            player.GetComponent<Player>().Reiniciar();
        }
        if (Arista2.x > 10 || Arista2.x < -10 || Arista2.y > 5 || Arista2.y < -5)
        {
            player.GetComponent<Player>().Reiniciar();
        }
        if (Arista3.x > 10 || Arista3.x < -10 || Arista3.y > 5 || Arista3.y < -5)
        {
            player.GetComponent<Player>().Reiniciar();
        }
        if (Arista4.x > 10 || Arista4.x < -10 || Arista4.y > 5 || Arista4.y < -5)
        {
            player.GetComponent<Player>().Reiniciar();
        }
    }
        
}

