using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtoResultManager : MonoBehaviour
{
    [SerializeField]
    private ResultEtoInfo etoPrefab;



    // Start is called before the first frame update
    void Start()
    {
        CreateResultEtoInfo();
    }

    private void CreateResultEtoInfo()
    {

        for (int i = 0; i < EtoInfoManager.instance.etoInfoList.Count; i++)
        {
            ResultEtoInfo resultEtoPrefab = Instantiate(etoPrefab, transform, false);

            resultEtoPrefab.SetUpEtoInfo(EtoInfoManager.instance.etoInfoList[i].etoType, i + 1, EtoInfoManager.instance.etoInfoList[i].point);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
