using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        //Only specify the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Scene4.1", LoadSceneMode.Single);
    }
}
