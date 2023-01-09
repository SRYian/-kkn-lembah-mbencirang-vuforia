using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    public GameObject lihatPeta;
    public GameObject lihatKamera;
    public Camera mapCamera;
    public Camera debugPathCamera;

    private bool _currentViewIsPeta;

    public void OnButtonClick()
    {
        _currentViewIsPeta = !_currentViewIsPeta;
        _changeMode();
    }

    private void _changeMode()
    {
        if (_currentViewIsPeta)
        {
            lihatPeta.SetActive(false);
            lihatKamera.SetActive(true);
            mapCamera.enabled = true;
            debugPathCamera.enabled = true;
        }
        else
        {
            lihatPeta.SetActive(true);
            lihatKamera.SetActive(false);
            mapCamera.enabled = false;
            debugPathCamera.enabled = false;
        }
    }
}