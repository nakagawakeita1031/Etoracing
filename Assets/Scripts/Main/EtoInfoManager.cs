using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EtoInfoManager : MonoBehaviour
{
    public static EtoInfoManager instance;

    [SerializeField]
    private EtoInfo etoInfoPrefab; //EtoInfoクラスのアタッチされているゲームオブジェクトのプレフェブをアサイン

    [SerializeField, Header("干支のポイントによる降順の順位リスト")]
    public List<EtoInfo> etoInfoList = new List<EtoInfo>();

    [SerializeField, Header("ポイント用の乱数設定")]
    private int[] points;

    private const int maxEtoInfoNum = 3; //干支の最大数。定数として利用する場合にはconst修飾子を活用する

    [SerializeField]
    private List<int> randomPointList = new List<int>(); //points配列を使って作るpointのリスト

    public EtoInfo myEtoInfo; //プレイヤーの干支情報

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// EtoInfoListをEtoResultManagerに提供する
    /// </summary>
    /// <returns></returns>
    public List<EtoInfo> GetEtoInfoList()
    {
        return etoInfoList;
    }

    // Start is called before the first frame update
    void Start()
    {
        //NPC用に配布する干支のポイントをランダムに順番設定
        SetRandomPoints();

        //干支情報の生成
        CreateEtoInfos();

        //ポイントの降順で順番のList並び替え
        SortByPoint();
        
    }

    /// <summary>
    /// 干支情報を生成
    /// </summary>
    private void CreateEtoInfos()
    {
        //干支情報を最大数作る
        for (int i = 0; i < maxEtoInfoNum; i++)
        {
            //干支情報の生成
            EtoInfo etoInfo = Instantiate(etoInfoPrefab, transform, false);

            //干支情報の設定
            etoInfo.SetUpEtoInfo(i, randomPointList[i]);

            //順位管理用のListに追加
            etoInfoList.Add(etoInfo);

            //最後の生成の場合、それをプレイヤーにする
            if (i == maxEtoInfoNum - 1)
            {
                //プレイヤーの干支情報として設定
                myEtoInfo = etoInfo;
            }
        }
    }

    /// <summary>
    /// 干支のポイントをランダムで順番設定
    /// </summary>
    private void SetRandomPoints()
    {
        //points配列をもとにして、Listを作成する
        List<int> tempPointList = new List<int>(points);

        //干支の最大数を目標に繰り返し処理をする
        for (int i = 0; i < maxEtoInfoNum; i++)
        {
            //ランダムな値を取得(tempPointListの最大値は、for文が繰り返されるたびに1づつ減っていく)
            int index = Random.Range(0, tempPointList.Count);

            //ランダムなpointを設定するためにListに、pointを代入
            randomPointList.Add(tempPointList[index]);

            //利用したpointを削除し、同じ値を重複して利用しないようにする
            tempPointList.Remove(tempPointList[index]);
        }
    }

    /// <summary>
    /// ポイントの降順でListの順番を並び替え
    /// </summary>
    private void SortByPoint()
    {
        //ポイントの降順で順番の並び替え
        etoInfoList = etoInfoList.OrderByDescending(x => x.point).ToList();
    }

    /// <summary>
    /// ポイント加算
    /// </summary>
    /// <param name="amount"></param>
    public void AddPoint(int amount)
    {
        myEtoInfo.point += amount;

        //ポイントの表示更新
        myEtoInfo.DisplayPoint();
    }


    // Update is called once per frame
    void Update()
    {
        //Debug用
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //ポイント加算
            AddPoint(100);

            //ポイントの降順で順番のList並び替え
            SortByPoint();
        }
    }
}
