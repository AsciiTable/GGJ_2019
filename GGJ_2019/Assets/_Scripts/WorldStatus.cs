using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WorldStatus : MonoBehaviour
{
    private Transform playerTrans;

    //ToyHouse
    public bool CaveBackground = false;

    //Campfire
    public bool ForestBackground = false;

    //Clock
    public bool GrandfatherClock = false;

    //is viewing stars
    public bool starGaze = false;

    public int collection = 0;
    public int livingRoom = 0;

    public bool playerLeft; //Is the player going to show up on the left side?

    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("ScriptHolder");

        if(obj.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        playerTrans = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        if (SceneManager.GetActiveScene().name == "1 Cave" && playerLeft)
        {
            playerTrans.SetPositionAndRotation(new Vector3(16f,-3.1f),playerTrans.rotation);
        }
        if (starGaze)
        {
            Audio.PlaySound("stargaze");
        }
        else
        {
            if (collection == 1)
            {
                Audio.PlaySound("outOfCave");
            }
            else if (collection == 2)
            {
                Audio.PlaySound("reminder");
            }
            else if (collection == 3)
            {
                Audio.PlaySound("bitsOfColor");
            }
            else if (collection == 4)
            {
                Audio.PlaySound("bitsOfColor");
            }
            else if (collection == 5)
            {
                Audio.PlaySound("thisIsHome");
            }
            else if (collection == 6)
            {
                Audio.PlaySound("rememberance");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
