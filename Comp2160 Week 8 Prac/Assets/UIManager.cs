using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI p1ScoreText;
    [SerializeField] private TextMeshProUGUI p2ScoreText;
    static private UIManager instance;
    static public UIManager Instance
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreText(int player, int score)
    {
        if (player == 1)
        {
            p1ScoreText.text = "P1 Score: " + score;
        } else
        {
            p2ScoreText.text = "P2 Score: " + score;
        }
        
    }
}
