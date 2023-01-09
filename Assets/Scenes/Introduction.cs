using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        //Only specify the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
    }
}
