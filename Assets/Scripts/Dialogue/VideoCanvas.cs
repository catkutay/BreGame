// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class VideoCanvas : MonoBehaviour
// {
//     public GameObject videoPlayer;
//     public int timeToStop;
    

//     // Start is called before the first frame update
//     void Start()
//     {
//        videoPlayer.SetActive(false);
//     }

//     // Update is called once per frame
//     void OnTriggerEnter2D(Collider player)
//     {
//         if (player.gameObject.tag == "Player")
//         {
//             videoPlayer.SetActive(true);
//             Destroy(videoPlayer, timeToStop);
//         }
//     }
// }
