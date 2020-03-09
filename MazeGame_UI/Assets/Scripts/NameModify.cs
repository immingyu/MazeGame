using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class NameModify : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scripttext;

    string tmp = "키키";
    public void Debuging2()
    {
        scripttext.text = tmp.ToString();
        Debug.Log("button click");
    }
}
