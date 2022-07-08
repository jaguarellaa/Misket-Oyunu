using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public GameObject gameover;
    public Launcher launcher;
    public GridManager grdmngr;

    public Text gameovertxt;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="bubble")
        {
            gameover.SetActive(true);
            gameovertxt.text = grdmngr.score.ToString();
            launcher.startShooting = false;
        }
    }

}
