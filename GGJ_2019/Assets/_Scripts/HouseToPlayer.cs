using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseToPlayer : MonoBehaviour
{
    public GameObject player;
    public float playerByHouse;
    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance < playerByHouse)
        {
            Debug.Log("Yes I am here");
            spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
        }
    }
}
