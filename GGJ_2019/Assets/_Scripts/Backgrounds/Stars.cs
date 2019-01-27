using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    private WorldStatus worldStatus;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        worldStatus = GameObject.FindGameObjectWithTag("ScriptHolder").GetComponent<WorldStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        if(worldStatus.stars)
        {
            spriteRenderer.enabled = true;
        }
    }
}
