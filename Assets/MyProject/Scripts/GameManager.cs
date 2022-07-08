using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager gameManager;
    public Sprite[] sp;
    public List<int> randomList;
    public bool finished = false;
    /*int justToBeSURE=1; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("bubble");
            foreach (var item in objects)
            {
                GridMember gd = item.GetComponent<GridMember>();
                if (gd.kind== justToBeSURE) gd.state="Pop";
            }
                justToBeSURE++;
        }
    }*/      //For CheckingPurposes
    private void Awake()
    {
        if (gameManager == null) gameManager = this;
        else Destroy(gameObject);
        currentKind = GetARandomIndex();
        nextKind = GetARandomIndex();
    }
    public int GetARandomIndex()
    {
        int randomNumber;
        bool isInList = false;
        int Check = 0;
        do
        {
            Check++;
            randomNumber = (int)Random.Range(1f, 6f);
            foreach (var item in randomList)
            {
                if (item == randomNumber) isInList = true;
            }
            if (Check > 10000) break;
        } while (!isInList);
        return randomNumber;
    }

    public void mainmenubtn()
    {
        SceneManager.LoadScene(0);
    }
    public void RefreshBubbleList()
    {
        List<int> newList = new List<int>();
        GameObject[] objects = GameObject.FindGameObjectsWithTag("bubble");
        foreach (var item in objects)
        {
           
            if (item.TryGetComponent(out GridMember gridMember))
            {
                int s = gridMember.kind;
                if (!newList.Contains(s))
                {
                    newList.Add(s);
                } 
            }
        }
        randomList = newList;
    }

    public int GetNextKind()
    {
        currentKind = nextKind;
        nextKind = GetARandomIndex();
        return currentKind;
    }

    public int nextKind = 1, currentKind = 1;
    //public void AppReload()
    //{
    //    SceneManager.LoadSceen(0);
    //}

    public void Debug()
    {
        print("debug");
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void easyretry()
    {
        SceneManager.LoadScene(1);
    }

    public void medretry()
    {
        SceneManager.LoadScene(2);
    }

    public void hardretry()
    {
        SceneManager.LoadScene(3);
    }
}
