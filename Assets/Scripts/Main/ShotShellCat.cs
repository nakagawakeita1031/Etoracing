using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotShellCat : MonoBehaviour
{
    public float shotSpeed;

    [SerializeField]
    private GameObject shellCatPrefab;

    [SerializeField]
    //private AudioClip shotSE;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Shellcatを生成
            GameObject shellCat = Instantiate(shellCatPrefab, transform.position, Quaternion.identity);

            //砲弾についているRigidbodyコンポーネントにアクセス
            Rigidbody rb = shellCat.GetComponent<Rigidbody>();

            //ShellCatをz方向へ発射する
            rb.AddForce(transform.forward * shotSpeed);

            //５秒後に破壊
            Destroy(shellCat, 5.0f);

            //発射音
            //AudioSource.PlayClipAtPoint(shotSE, transform.position);

        }
    }
}
