using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMenu : MonoBehaviour
{
    public GameObject Panel;

    public void openSideMenu()
    {
        if(Panel.active == true)
        {
            Panel.SetActive(false);
        }
        else
        {
            Panel.SetActive(true);
        }
    }
}
