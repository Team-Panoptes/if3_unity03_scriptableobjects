using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDialog : MonoBehaviour
{


    public DialogMessage currentMessage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentMessage != null) {
            Debug.Log(currentMessage.message);
            currentMessage = currentMessage.GetNextMessage();
        }
    }
}
