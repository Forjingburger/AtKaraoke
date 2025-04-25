using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float inputX = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(inputX, 0, 0).normalized * moveSpeed * Time.deltaTime;

        transform.Translate(move, Space.World);

        if(Input.GetKey(KeyCode.A))
        {
            spriteRenderer.flipX = true;
        }
        if(Input.GetKey(KeyCode.D))
        {
            spriteRenderer.flipX = false;
        }

    }
}
