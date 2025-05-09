using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{ // y = -4 ilk platform 2. platform -2 de bu da 2 platform arasında 2 birim fark var demektir.
    public float jumpPower;
    private Camera cmr;
    private float distance;
    private float rnd;
    private void Start()
    {
        cmr = Camera.main;
    }
    private void Update()
    {     
        distance = cmr.transform.position.y - transform.position.y;
        if (distance >= 5.20f)
        {
            rnd = Random.Range(-1.672f, 1.672f);
            transform.position = new Vector2(rnd, transform.position.y + 14f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D CharacterRB;
        if (collision.gameObject.CompareTag("Character") && collision.relativeVelocity.y <= 0)
        {
            CharacterRB = collision.gameObject.GetComponent<Rigidbody2D>();
            CharacterRB.velocity = new Vector2(CharacterRB.velocity.x, jumpPower);
        }
    }
}
