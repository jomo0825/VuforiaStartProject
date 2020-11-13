using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    public AudioClip clipToPlay;
    public Text txt;
    public int lineNum = 1;
    public List<int> answers;

    private AudioSource asource;

    void Awake()
    {
        asource = GetComponent<AudioSource>();
        if (asource == null)
        {
            asource = gameObject.AddComponent<AudioSource>();
        }
        asource.spatialBlend = 0;

        answers = new List<int>();
    }

    void Update() {

        if (lineNum == 1)
        {
            txt.text = "這是第一題:太陽的英文是甚麼? A. Sun B. Moon C. Star";
        }
        else if (lineNum == 2)
        {
            txt.text = "這是第二題";
        }
        else if (lineNum == 3)
        {
            txt.text = "這是第三題";
        }
        else if (lineNum == 4)
        {
            txt.text = "這是第四題";
        }
        else if (lineNum == 5)
        {
            txt.text = "這是第五題";
        }

    }


    public void OnButtonClicked(int choice) {
        if (clipToPlay != null && asource != null)
        {
            asource.clip = clipToPlay;
            asource.Play();
        }

        lineNum = lineNum + 1;
        answers.Add(choice);
    }
}
