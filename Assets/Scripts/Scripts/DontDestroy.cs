using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject[] players;
     private static bool playerExists;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnLevelWasLoaded(int level)
    {
        FindStartPos();
        players = GameObject.FindGameObjectsWithTag("Player");
        if(players.Length > 1)
        {
            Destroy(players[1]);
        }
    }

    void FindStartPos()
   {
    transform.position = GameObject.FindWithTag("StartPos").transform.position;
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
