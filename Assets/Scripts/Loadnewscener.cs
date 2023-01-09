using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadnewscener : MonoBehaviour
{
    void OnEnable()
    {
        //Only specify the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

}
