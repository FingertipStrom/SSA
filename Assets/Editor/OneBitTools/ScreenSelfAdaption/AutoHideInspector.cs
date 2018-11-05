using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AutoRotate))]
public class AutoHideInspector : Editor {

   // private SerializedObject m_SerializedObject;
    private AutoRotate m_AutoRotate;

    private SerializedProperty m_AutoRotate_H;
    private SerializedProperty m_AutoRotate_V;

    void OnEnable()
    {
        //m_SerializedObject = new SerializedObject(target);

    }

    public override void OnInspectorGUI()
    {
        m_AutoRotate = target as AutoRotate;
        m_AutoRotate.m_AutoHideType = (AutoHideType)EditorGUILayout.EnumPopup("AutoHideType", m_AutoRotate.m_AutoHideType);

        switch (m_AutoRotate.m_AutoHideType)
        {
            case AutoHideType.H:              
                if(GUILayout.Button("保存横屏数据"))
                {
                    m_AutoRotate.SaveH();
                }
                break;
            case AutoHideType.V:               
                if (GUILayout.Button("保存竖屏数据"))
                {
                    m_AutoRotate.SaveV();
                }
                break;
        }
    }
}
