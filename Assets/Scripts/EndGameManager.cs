using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    public GameObject gameScreen;
    public GameObject endScreen;
    public GameObject[] unlockeds;
    public GameObject[] lockeds;

    public void checkEnd()
    {
        bool isEnd = true;
        foreach (var unlocked in unlockeds)
        {
            if (!unlocked.activeSelf) isEnd = false;
        }

        if (isEnd)
        {
            gameScreen.SetActive(false);
            endScreen.SetActive(true);
        }
    }

    public void playAgain()
    {
        foreach (var unlocked in unlockeds)
        {
            unlocked.SetActive(false);
        }
        
        foreach (var locked in lockeds)
        {
            locked.SetActive(true);
        }
    }
}
