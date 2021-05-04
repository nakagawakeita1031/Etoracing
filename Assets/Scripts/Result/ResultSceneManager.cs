using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultSceneManager : MonoBehaviour
{
    [SerializeField]
    private Button buttonResult;

    // Start is called before the first frame update
    void Start()
    {
        buttonResult.onClick.AddListener(ReturnStart);
    }

    void ReturnStart()
    {
        SceneManager.LoadScene("Start");
    }
}
