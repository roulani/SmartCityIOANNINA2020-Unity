using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class News : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene("NewsScene");
    }
}
