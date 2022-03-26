using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.RecountHealthPoints(-1);
            Rigidbody2D rb =
            collision.gameObject.GetComponent<Rigidbody2D>();
             rb.AddForce(transform.up * 5f, ForceMode2D.Impulse);
        }
    }
}
