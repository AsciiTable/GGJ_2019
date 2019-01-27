using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private WorldStatus worldStatus;

    public string nextScene;
    public bool Positive;


    private void Start()
    {
        worldStatus = GameObject.FindGameObjectWithTag("ScriptHolder").GetComponent<WorldStatus>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nextScene);
            if (Positive)
            {
                worldStatus.playerPosition++;
            }
            else if(!Positive)
            {
                worldStatus.playerPosition--;
            }
        }

    }
}
