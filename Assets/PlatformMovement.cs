using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-1, 0) * Time.deltaTime * 5);

        if(transform.position.x < -10.3f)
        {

        Destroy(gameObject);
        }
    }
}
