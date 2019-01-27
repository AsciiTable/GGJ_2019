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
    public bool stopGaze = false;
    public bool starReady = true;
    public bool stars = false;

    public int collection = 0;
    public int livingRoom = 0;

    public bool playerLeft; //Is the player going to show up on the left side?

    private AudioSource music;

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
        music = GetComponent<AudioSource>();

        if (SceneManager.GetActiveScene().name == "1 Cave" && playerLeft)
        {
            playerTrans.SetPositionAndRotation(new Vector3(16f,-3.1f),playerTrans.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
