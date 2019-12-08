using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Text_Title : MonoBehaviour
{
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text=DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName;
    }
}
