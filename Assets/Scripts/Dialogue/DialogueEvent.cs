using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[System.Serializable]
public class DialogueEvent
{
   [HideInInspector] public string name;
   [SerializeField] private UnityEvent onPickedResponse;

   public UnityEvent OnPickedResponse => onPickedResponse;
}
