using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
