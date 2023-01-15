using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitikObjekManager : MonoBehaviour
{
    public GameObject locked;
    public GameObject unlocked;
    
    public void captureObject()
    {
        locked.SetActive(false);
        unlocked.SetActive(true);
    }
}

