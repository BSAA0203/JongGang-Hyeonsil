using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public void Move_to_cam()
    {
        SceneManager.LoadScene("AR_Cam");
    }

    public void Move_to_list()
    {
        SceneManager.LoadScene("List");
    }
}
