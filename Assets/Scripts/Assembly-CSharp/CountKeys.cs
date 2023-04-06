using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class CountKeys : MonoBehaviour
{
    public int keys;

    public Text keyCounterText;

    public virtual void Start()
    {
        //Granny's house! I don't wanna stay. Take me home right now, I don't wanna stay at Granny's houseee!
    }

    public virtual void Update()
    {
        keyCounterText.text = keys.ToString();
    }

    public virtual void countUpkeys()
    {
        keys++;
    }

    public virtual void countDownkeys()
    {
        keys--;
    }
}
