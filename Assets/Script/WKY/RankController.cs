using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using MusicGame;

public class RankController : MonoBehaviour {
    StageData stageData = null;
    ScoreBoard scoreBoard = null;

    GameObject group = null;
    GameObject titleGroup = null;
    GameObject scoreGroup = null;
    GameObject comboGroup = null;
    GameObject rankGroup = null;

    GameObject title = null;
    GameObject author = null;
    GameObject scoreNum = null;
    GameObject comboNum = null;
    GameObject perfectNum = null;
    GameObject goodNum = null;
    GameObject badNum = null;
    GameObject missNum = null;
    GameObject rank = null;

	// Use this for initialization
	void Start () {
        stageData = StageData.GetInstance();
        scoreBoard = ScoreBoard.GetInstance();

        group = GameObject.Find("Group");
        titleGroup = GameObject.Find("TitleGroup");
        scoreGroup = GameObject.Find("ScoreGroup");
        comboGroup = GameObject.Find("ComboGroup");
        rankGroup = GameObject.Find("RankGroup");

        title = GameObject.Find("Title");
        author = GameObject.Find("Author");
        scoreNum = GameObject.Find("ScoreNum");
        comboNum = GameObject.Find("ComboNum");
        perfectNum = GameObject.Find("PerfectNum");
        goodNum = GameObject.Find("GoodNum");
        badNum = GameObject.Find("BadNum");
        missNum = GameObject.Find("MissNum");
        rank = GameObject.Find("Rank");

        title.GetComponent<Text>().text = stageData.Title;
        author.GetComponent<Text>().text = stageData.Author;
        scoreNum.GetComponent<Text>().text = scoreBoard.Score.ToString("D8");
        comboNum.GetComponent<Text>().text = scoreBoard.MaxCombo.ToString();
        perfectNum.GetComponent<Text>().text = scoreBoard.Perfect.ToString();
        goodNum.GetComponent<Text>().text = scoreBoard.Good.ToString();
        badNum.GetComponent<Text>().text = scoreBoard.Bad.ToString();
        missNum.GetComponent<Text>().text = scoreBoard.Miss.ToString();

        ComputeRank();
        DoMoves();
        AddButtonCallbacks();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ComputeRank()
    {
        float scoreRatio = scoreBoard.Score * 1.0f / stageData.MaxScore;
        if (scoreRatio >= 0.995)
        {
            rank.GetComponent<Text>().text = "SSS";
        }
        else if (scoreRatio >= 0.975)
        {
            rank.GetComponent<Text>().text = "SS";
        }
        else if (scoreRatio >= 0.95)
        {
            rank.GetComponent<Text>().text = "S";
        }
        else if (scoreRatio >= 0.9)
        {
            rank.GetComponent<Text>().text = "A";
        }
        else if (scoreRatio >= 0.8)
        {
            rank.GetComponent<Text>().text = "B";
        }
        else if (scoreRatio >= 0.6)
        {
            rank.GetComponent<Text>().text = "C";
        }
        else
        {
            rank.GetComponent<Text>().text = "D";
        }
    }

    void DoMoves()
    {
        this.titleGroup.transform.DOMove(new Vector3(Screen.width / 2, Screen.height / 2, 0), 2).SetEase(Ease.OutSine);
        this.scoreGroup.transform.DOMove(new Vector3(Screen.width / 2, Screen.height / 2, 0), 2).SetEase(Ease.OutSine);
        this.comboGroup.transform.DOMove(new Vector3(Screen.width / 2, Screen.height / 2, 0), 2).SetEase(Ease.OutSine);
        this.rankGroup.transform.DOMove(new Vector3(Screen.width / 2, Screen.height / 2, 0), 2).SetEase(Ease.OutSine);
    }

    void AddButtonCallbacks()
    {
        UIEventListener.Get(GameObject.Find("ButtonBack")).onClick = (GameObject sender) =>
        {
            SceneManager.LoadScene("start");
        };

        UIEventListener.Get(GameObject.Find("ButtonRetry")).onClick = (GameObject sender) =>
        {
            SceneManager.LoadScene("play");
        };
    }
}
