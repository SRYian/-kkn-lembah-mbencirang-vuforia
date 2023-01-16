using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_AR : MonoBehaviour
{
    public GameObject Button;
    public GameObject unlocked;
    private bool isEnable;

    private void Start()
    {
        Button.SetActive(false);
    }
    public void ToggleObject()
    {
        if (!unlocked.activeSelf)
        {
            Button.SetActive(true);
        }
    }
}
