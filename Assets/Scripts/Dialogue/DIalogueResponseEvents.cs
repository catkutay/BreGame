
using UnityEngine;
using System;


public class DIalogueResponseEvents : MonoBehaviour
{
    [SerializeField] private DialogueObject dialogueObject;
    [SerializeField] private DialogueEvent[] events;

    public DialogueObject DialogueObject => dialogueObject;

    public DialogueEvent[] Events => events;

    public void OnValidate()
    {
        if(dialogueObject == null) return;
        if(dialogueObject.Responses == null) return;
        if (events != null && events.Length == dialogueObject.Responses.Length) return;

        if (events == null)
        {
            events = new DialogueEvent[dialogueObject.Responses.Length];
        }
        else
        {
            Array.Resize(ref events, dialogueObject.Responses.Length);
        }

        for (int i = 0; i < dialogueObject.Responses.Length; i++)
        {
            Response response = dialogueObject.Responses[i];

            if (events[i] != null)
            {
                //Gets the names of the responses from the 
                //Dialogue Data Object that is added
                events[i].name = response.ResponseText;
                continue;
            }

            events[i] = new DialogueEvent(){name = response.ResponseText};
        }
    }
}
