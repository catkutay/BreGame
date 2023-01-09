using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//This code if used to refresh the options if they are
//updates in the DialogueObject
[CustomEditor(typeof(DIalogueResponseEvents))]

public class DialogueResponseEventsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        DIalogueResponseEvents responseEvents = (DIalogueResponseEvents)target;

        if (GUILayout.Button("Refresh"))
        {
            responseEvents.OnValidate();
        }
    }
}
