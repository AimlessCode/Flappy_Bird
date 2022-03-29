using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManeger : MonoBehaviour
{
    public  GameObject gameovertype;

    void Start()
    {
        Time.timeScale = 1;

    }


    void Update()
    {



    }
    public void gameOver()
    {

        gameovertype.SetActive(true);

        Time.timeScale = 0;
    }

}
