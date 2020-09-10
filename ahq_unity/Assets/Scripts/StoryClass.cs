using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryClass : MonoBehaviour
{
    public Text StoryText;
    public string Author;

    private int StoryID;
    private string CreationTime;

    private bool Judgement;

    // Start is called before the first frame update
    void Start()
    {
        StoryID = Random.Range(0, 20000);
        CreationTime = System.DateTime.Now.ToString("yyyy/MM/dd\thh:mm:ss");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CreationTime + "\tThis is a StoryID " + StoryID + 
                " and this is the judgement " + Judgement);
    }

    public void SetJudgement(bool judgement)
    {
        Judgement = judgement;
    }

}
