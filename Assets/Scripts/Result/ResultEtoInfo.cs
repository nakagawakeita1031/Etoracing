using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultEtoInfo : MonoBehaviour
{
    public EtoType etoType;

    public int rank;

    public Image rankImg;

    public Image etoImage;

    public int score;

    public Text scoreText;




    public void SetUpEtoInfo(EtoType etoType, int rank, int score)
    {
        this.etoType = etoType;

        this.rank = rank;

        this.score = score;

        if (this.etoType != EtoType.猫)
        {
            // 干支の画像の設定(画像を Resources フォルダより読み込む。別の方法でも可)
            etoImage.sprite = Resources.Load<Sprite>("EtoIcon/" + (int)etoType);
        }
        else
        {
            // 干支の画像の設定(画像を Resources フォルダより読み込む。別の方法でも可)
            etoImage.sprite = Resources.Load<Sprite>("EtoIcon/" + ((int)etoType + 1));
        }

        DisplayPoint();

    }

    public void DisplayPoint()
    {
        rankImg.sprite = Resources.Load<Sprite>("Rank/" + rank);


        scoreText.text = score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
