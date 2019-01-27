using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestColor : MonoBehaviour
{
    private WorldStatus worldStatus;
    private Animator animator;
    private float change = 0f;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        worldStatus = GameObject.FindGameObjectWithTag("ScriptHolder").GetComponent<WorldStatus>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (worldStatus.ForestBackground && change < 1)
        {
            timer += Time.deltaTime;
            animator.SetTrigger("addColor");
        }

        if (timer >= 2f && change == 0)
        {
            change++;
            animator.enabled = false;
        }
    }
}
