using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitikObjekPanel : MonoBehaviour
{
    public GameObject aloeVeraLocked;
    public GameObject jaheLocked;
    public GameObject kencurLocked;
    public GameObject kunyitLocked;
    public GameObject lengkuasLocked;
    public GameObject temulawakLocked;
    
    public GameObject aloeVeraUnlocked;
    public GameObject jaheUnlocked;
    public GameObject kencurUnlocked;
    public GameObject kunyitUnlocked;
    public GameObject lengkuasUnlocked;
    public GameObject temulawakUnlocked;
    
    public GameObject gameScreen;
    public GameObject endScreen;

    private bool _aloeVera;
    private bool _jahe;
    private bool _kencur;
    private bool _temulawak;
    private bool _kunyit;
    private bool _lengkuas;

    public void captureAloeVera()
    {
        aloeVeraLocked.SetActive(false);
        aloeVeraUnlocked.SetActive(true);
        _aloeVera = true;
        _checkEnd();
    }

    public void captureJahe()
    {
        jaheLocked.SetActive(false);
        jaheUnlocked.SetActive(true);
        _jahe = true;
        _checkEnd();
    }
    
    public void captureKencur()
    {
        kencurLocked.SetActive(false);
        kencurUnlocked.SetActive(true);
        _kencur = true;
        _checkEnd();
    }
    
    public void captureTemulawak()
    {
        temulawakLocked.SetActive(false);
        temulawakUnlocked.SetActive(true);
        _temulawak = true;
        _checkEnd();
    }
    
    public void captureKunyit()
    {
        kunyitLocked.SetActive(false);
        kunyitUnlocked.SetActive(true);
        _kunyit = true;
        _checkEnd();
    }
    
    public void captureLengkuas()
    {
        lengkuasLocked.SetActive(false);
        lengkuasUnlocked.SetActive(true);
        _lengkuas = true;
        _checkEnd();
    }

    private void _checkEnd()
    {
        if (_aloeVera && _jahe && _kencur && _temulawak && _kunyit && _lengkuas)
        {
            gameScreen.SetActive(false);
            endScreen.SetActive(true);
        } 
    }

    public void playAgain()
    {
        _aloeVera = false;
        _jahe = false;
        _kencur = false;
        _temulawak = false;
        _kunyit = false;
        _lengkuas = false;
        
        aloeVeraLocked.SetActive(true);
        jaheLocked.SetActive(true);
        kencurLocked.SetActive(true);
        kunyitLocked.SetActive(true);
        lengkuasLocked.SetActive(true);
        temulawakLocked.SetActive(true);
            
        aloeVeraUnlocked.SetActive(false);
        jaheUnlocked.SetActive(false);
        kencurUnlocked.SetActive(false);
        kunyitUnlocked.SetActive(false);
        lengkuasUnlocked.SetActive(false);
        temulawakUnlocked.SetActive(false);
    }
}
