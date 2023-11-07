using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DialogMessage : ScriptableObject
{

    public string message;
    public DialogMessage[] next;

    public DialogMessage GetNextMessage() {
        if (next != null && next.Length > 0) {
            return next[0];
        } else {
            return null;
        }
    }


}
