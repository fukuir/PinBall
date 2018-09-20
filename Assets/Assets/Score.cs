using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //scoreを表示するテキスト
    private GameObject scoreText;
    private int score = 0;
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("scoreText");
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += 25;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 50;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 150;
        }
        //ScoreText獲得した点数を表示
        this.scoreText.GetComponent<Text>().text = score.ToString() + "P";
    }
}
