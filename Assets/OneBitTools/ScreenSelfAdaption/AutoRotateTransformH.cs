using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotateTransformH : MonoBehaviour {
    public bool isSaved = false;
    public Vector2 anchoredPosition;
    public Vector3 anchoredPosition3D;
    public Vector2 anchorMax;
    public Vector2 anchorMin;
    public Vector2 offsetMax;
    public Vector2 offsetMin;
    public Vector2 pivot;
    public Vector2 sizeDelta;
    public Quaternion rotation;
    public Vector3 scale;

    public void Set(RectTransform rt)
    {
        isSaved = true;
        anchoredPosition = rt.anchoredPosition;
        anchoredPosition3D = rt.anchoredPosition3D;
        anchorMax = rt.anchorMax;
        anchorMin = rt.anchorMin;
        offsetMax = rt.offsetMax;
        offsetMin = rt.offsetMin;
        pivot = rt.pivot;
        sizeDelta = rt.sizeDelta;
        rotation = rt.rotation;
        scale = rt.localScale;
    }

    public void Get(ref RectTransform rt)
    {
        rt.anchoredPosition = anchoredPosition;
        rt.anchoredPosition3D = anchoredPosition3D;
        rt.anchorMax = anchorMax;
        rt.anchorMin = anchorMin;
        rt.offsetMax = offsetMax;
        rt.offsetMin = offsetMin;
        rt.pivot = pivot;
        rt.sizeDelta = sizeDelta;

        rt.rotation = rotation;
        rt.localScale = scale;
    }

}
