using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject menuPanel;

    private bool _isOpen;

    public void OnButtonClick()
    {
        _isOpen = !_isOpen;
        _toggleMenuPanel();
    }

    private void _toggleMenuPanel()
    {
        if (!_isOpen) menuPanel.SetActive(false);
        else menuPanel.SetActive(true);
    }
}
