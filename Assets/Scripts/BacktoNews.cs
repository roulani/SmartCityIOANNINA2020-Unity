using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoNews : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene("NewsScene");
    }
}
