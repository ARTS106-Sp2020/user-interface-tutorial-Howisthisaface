using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_ManagerScript : MonoBehaviour
{
    public void StartGame()
    {
      SceneManager.LoadScene("RocketMouse");
    }
}