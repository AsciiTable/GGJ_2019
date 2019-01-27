using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldStatus : MonoBehaviour
{
    //ToyHouse
    public bool CaveBackground = false;

    //Campfire
    public bool ForestBackground = false;

    //Clock
    public bool GrandfatherClock = false;

    public int collection = 0;
    public int livingRoom = 0;

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

    // Update is called once per frame
    void Update()
    {
    }
}
