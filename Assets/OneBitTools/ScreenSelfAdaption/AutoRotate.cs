using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AutoHideType
{
    H,
    V
}

[ExecuteInEditMode]
[RequireComponent(typeof(AutoRotateTransformH),typeof(AutoRotateTransformV))]

public class AutoRotate : MonoBehaviour {

    public AutoHideType m_AutoHideType;
    
    RectTransform m_RectTransform;    
    // Use this for initialization
    void Start () {
        m_RectTransform = GetComponent<RectTransform>();        
    }
#if UNITY_EDITOR
    public void SaveH()
    {
        GetComponent<AutoRotateTransformH>().Set(m_RectTransform);
    }

    public void SaveV()
    {
        GetComponent<AutoRotateTransformV>().Set(m_RectTransform);
    }
#endif

    // Update is called once per frame
    void Update () {

        //Debug.Log(m_Transform_H.anchoredPosition.ToString());
        if (Screen.width > Screen.height)
            m_AutoHideType = AutoHideType.H;
        else
            m_AutoHideType = AutoHideType.V;
        var rect = GetComponent<RectTransform>();
        switch (m_AutoHideType)
        {
            case AutoHideType.H:
                var h = GetComponent<AutoRotateTransformH>();
                if (h.isSaved) h.Get(ref rect);
                break;

            case AutoHideType.V:
                var v = GetComponent<AutoRotateTransformV>();
                if (v.isSaved) v.Get(ref rect);
                break;
        }  
        
	}
}

