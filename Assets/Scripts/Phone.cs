using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Phone : MonoBehaviour
{
    public void loadPhoneScene()
    {
        SceneManager.LoadScene("PhoneScene");
    }
}

