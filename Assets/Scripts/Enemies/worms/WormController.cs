using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    float velocity = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocity * Time.deltaTime);
        RaycastHit2D groundinfo = 
        Physics2D.Raycast(grounDetect.position, Vector2.down, 1f);
    }
}
