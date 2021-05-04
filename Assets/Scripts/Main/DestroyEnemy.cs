using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public int EnemyHP;
    [SerializeField]
    private GameObject effectPrefab;

    [SerializeField]
    private int scoreValue;
    private ScoreManager sm;

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("ScoreLabel").GetComponent<ScoreManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShellCat"))
        {
            EnemyHP -= 1;

            if (EnemyHP > 0)
            {
                Destroy(other.gameObject);

            }
            else
            {
                Destroy(other.gameObject);

                Destroy(gameObject);

                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

                Destroy(effect, 2.0f);

                sm.AddScore(scoreValue);
            }


            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
