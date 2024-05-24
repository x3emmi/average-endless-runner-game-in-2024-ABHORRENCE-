using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.AddForce(Vector3.up * 10, ForceMode2D.Impulse);
    
        }

    }
}