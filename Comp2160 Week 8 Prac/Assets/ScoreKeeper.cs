using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int score = 0;
    static private ScoreKeeper instance;
    static public ScoreKeeper Instance
    {
        get
        {
            if(instance == null)
            {
                Debug.LogError("There is no UIManager in the scene.");
            }
            return instance;
        }
    }
    void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        UIManager.Instance.UpdateScoreText(score);
    }
    public void UpdateScore(int s)
    {
        score += s;
        UIManager.Instance.UpdateScoreText(score);
    }
}
