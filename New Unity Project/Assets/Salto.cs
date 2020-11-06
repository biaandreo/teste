using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public Vector3 direcao = new Vector3Int(0,3,0);
    public float forca =500;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(direcao * forca);
        }
    }
      private void OnTriggerEnter(Collider other) 
    {
        if (other.GetComponent<Obstáculo> () == true)
        {Morre();
        }
    }
    private void Morre()
    {
        Destroy(gameObject);
    }
}
