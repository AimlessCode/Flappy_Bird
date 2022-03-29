using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
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

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

}
