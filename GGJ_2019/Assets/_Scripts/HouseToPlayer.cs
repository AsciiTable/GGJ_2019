using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseToPlayer : MonoBehaviour
{
    public GameObject player;
    public float playerByHouse;
    public float fadeSpeed;

    private float opacityTime;
    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        opacityTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance < playerByHouse)
        {
            Audio.PlaySound("door_open");

            if (opacityTime >= 0)
            {
                opacityTime -= Time.deltaTime * fadeSpeed;
            }
            spriteRenderer.color = new Color(1f, 1f, 1f, opacityTime);  
        }
        else if (distance >= playerByHouse)
        {
            if (opacityTime <= 1)
            {
                opacityTime += Time.deltaTime * fadeSpeed;
            }
            spriteRenderer.color = new Color(1f, 1f, 1f, opacityTime);
        }
    }
}
