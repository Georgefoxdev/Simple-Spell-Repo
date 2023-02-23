using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour


{
    public string sportscene;
    public string spacescene;
    public string gardenscene;
    public string fooddrinkscene;



    // Start is called before the first frame update

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }



    public void playgamesport()
    {
        SceneManager.LoadScene(8);
    }

    public void playgamespace()
    {
        SceneManager.LoadScene(7);
    }

    public void playgamegarden()
    {
        SceneManager.LoadScene(6);
    }


    public void playgamefooddrinks()
    {
        SceneManager.LoadScene(5);
    }

    public void playfood2()
    {
        SceneManager.LoadScene(1);
    }

    public void playfood3()
    {
        SceneManager.LoadScene(10);
    }

    public void playfood4()
    {
        SceneManager.LoadScene(9);
    }

    public void playnature2()
    {
        SceneManager.LoadScene(12);
    }

    public void playnature3()
    {
        SceneManager.LoadScene(2);
    }

    public void playnature4()
    {
        SceneManager.LoadScene(11);
    }

    public void playspace2()
    {
        SceneManager.LoadScene(3);
    }

    public void playspace3()
    {
        SceneManager.LoadScene(14);
    }

    public void playspace4()
    {
        SceneManager.LoadScene(13);
    }

    public void playsport2()
    {
        SceneManager.LoadScene(4);
    }

    public void playsport3()
    {
        SceneManager.LoadScene(16);
    }

    public void playsport4()
    {
        SceneManager.LoadScene(15);
    }





    public void exitGame()
    {
        Application.Quit();
    }
}
