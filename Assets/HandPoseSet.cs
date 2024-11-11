using Leap;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HandPoseSet : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI checkText;


    public HandPoseScriptableObject[] HandArray;

    public HandPoseEditor ScriptPose;


    public HandPoseScriptableObject HandAux;

    private void Start()
    {
        ScriptPose = gameObject.GetComponent<HandPoseEditor>();
        HandAux = ScriptPose.handPose;
    }
    // Update is called once per frame
    void Update()
    {
        if (checkText.text == "One")
        {
            ScriptPose.handPose = HandArray[0];
            Debug.Log("POSE ONE");
        }
        else if (checkText.text == "Two")
        {
            ScriptPose.handPose = HandArray[1];
        }
        else if (checkText.text == "Three")
        {
            ScriptPose.handPose = HandArray[2];
        }
        else if (checkText.text == "Four")
        {
            ScriptPose.handPose = HandArray[3];
        }
        else if (checkText.text == "Five")
        {
            ScriptPose.handPose = HandArray[4];
        }
    }

}
