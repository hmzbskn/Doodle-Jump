using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    private Rigidbody2D characterRB;
    public float hSpeed;
    // Start is called before the first frame update
    void Start()
    {
        characterRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = Input.GetAxis("Horizontal") * hSpeed;
        characterRB.velocity = new Vector2(speed, characterRB.velocity.y);
    }
}
