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
        if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "football")
        {
            txt.text="FootBall";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Ginyeom-Gwan")
        {
            txt.text="Ginyeom-Gwan";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Yeongam_Gwan")
        {
            txt.text="Yeongam_Gwan";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "GLOBAL-LOUNGE")
        {
            txt.text="GLOBAL-LOUNGE";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "SeongGyeol-Gwan")
        {
            txt.text="SeongGyeol-Gwan";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Hagsaenghoe-Gwan")
        {
            txt.text="Hagsaenghoe-Gwan";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Jaelim-Gwan")
        {
            txt.text="Jaelim-Gwan";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "FrontGate")
        {
            txt.text="FrontGate";
        }
    }
}
