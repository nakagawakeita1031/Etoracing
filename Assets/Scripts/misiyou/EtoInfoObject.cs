using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtoInfoObject : MonoBehaviour
{
    public EtoType etoType; //干支の種類
    public bool isMyInfo;//playerを認識するため
    public GameObject etoObject;//Prefabの設定

    public void SetUpEtoObject(int etoTypeNum)
    {
        //干支の種類を選択
        this.etoType = (EtoType)etoTypeNum;
        etoObject = Resources.Load<GameObject>("EtoObject/" + etoTypeNum);

        if (this.etoType == EtoType.猫)
        {
            isMyInfo = true;
        }
    }
}
