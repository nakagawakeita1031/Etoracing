using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EtoInfo : MonoBehaviour
{
    public EtoType etoType; //干支の種類
    public int point; //点数
    public Image etoImage; //画像の設定
    public Text txtPoint; //ポイントの表示

    public bool isMyInfo; //NPC or Player trueをPlayer

    /// <summary>
    /// 干支情報の設定
    /// </summary>
    /// <param name="etoTypeNum"></param>
    /// <param name="point"></param>
    public void SetUpEtoInfo(int etoTypeNum, int point)
    {
        //干支の種類を設定
        this.etoType = (EtoType)etoTypeNum;

        //ポイントの設定
        this.point = point;

        //ポイントの表示
        DisplayPoint();

        //干支の画像の設定(画像をResourceフォルダより読み込む。別の方法でも可)
        etoImage.sprite = Resources.Load<Sprite>("EtoIcon/" + etoTypeNum);

        //rとの種類が猫の場合
        if (this.etoType == EtoType.猫)
        {
            this.point = 0;
            isMyInfo = true;
        }


    }
    /// <summary>
    /// ポイントの表示更新
    /// </summary>
    public void DisplayPoint()
    {
        //ポイントの表示
        txtPoint.text = point.ToString();
    }
}
