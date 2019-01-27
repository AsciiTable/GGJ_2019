using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class UnlockCave : MonoBehaviour
{
    private WorldStatus worldStatus;
    private CinemachineVirtualCamera cinemachine;
    private GameObject tempBlock;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        worldStatus = GameObject.FindGameObjectWithTag("ScriptHolder").GetComponent<WorldStatus>();
        tempBlock = GameObject.Find("TempBlock");

        cinemachine = GetComponent<CinemachineVirtualCamera>();

    }

    // Update is called once per frame
    void Update()
    {
        if (worldStatus.CaveBackground == true)
        {
            cinemachine.enabled = true;

            if(tempBlock)
            {
                timer += Time.deltaTime;
            }
        }

        if(timer >= 8.0f)
        {
            Destroy(tempBlock.gameObject);
        }

    }
}
