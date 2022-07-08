using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MisketMenu : MonoBehaviour
{
   
    public void easybtn()
    {
        SceneManager.LoadScene(1);
    }
    public void medbtn()
    {
        SceneManager.LoadScene(2);
    }
    public void hardbtn()
    {
        SceneManager.LoadScene(3);
    }
}
