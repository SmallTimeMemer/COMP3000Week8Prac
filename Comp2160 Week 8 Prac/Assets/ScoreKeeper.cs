using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int p1Score = 0;
    private int p2Score = 0;
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
        UIManager.Instance.UpdateScoreText(1, p1Score);
        UIManager.Instance.UpdateScoreText(2, p2Score);
    }
    public void UpdateScore(int p, int s)
    {
        if(p == 1)
        {
            p1Score += s;
            UIManager.Instance.UpdateScoreText(1, p1Score);
        } else
        {
            p2Score += s;
            UIManager.Instance.UpdateScoreText(2, p2Score);
        }
        
    }
}
