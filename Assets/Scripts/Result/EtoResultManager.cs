using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtoResultManager : MonoBehaviour
{
    [SerializeField]
    private ResultEtoInfo EtoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        CreateResultEtoInfo();
    }

    private void CreateResultEtoInfo()
    {
        List<EtoInfo> etoInfoList = EtoInfoManager.instance.GetEtoInfoList();

        for (int i = 0; i < etoInfoList.Count; i++)
        {
            ResultEtoInfo ResultEtoPrefab = Instantiate(EtoPrefab, transform, false);

            ResultEtoInfo.SetUpEtoInfo(etoInfoList[i].etoType, etoInfoList[i].point, i + 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
