using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Notifications : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene("NotificationScene");
    }
}
