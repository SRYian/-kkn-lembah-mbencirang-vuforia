using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetManagement : MonoBehaviour
{
    public Camera camera;
    public GameObject target;
    public GameObject button;
    public GameObject unlocked;
    
    private bool IsVisible(Camera c, GameObject target)
    {
        var planes = GeometryUtility.CalculateFrustumPlanes(c);
        var point = target.transform.position;

        foreach (var plane in planes)
        {
            if (plane.GetDistanceToPoint(point) < 0)
            {
                return false;
            }
        }
        
        return true;
    }

    private void Update()
    {
        if (IsVisible(camera, target) && !unlocked.activeSelf)
        {
            button.SetActive(true);
        }
        else button.SetActive(false);
    }
}
