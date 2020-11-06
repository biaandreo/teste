using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 10;
    public Vector3 direcao = new Vector3(-1, 0, 0);
    public Material Obstáculo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

}
