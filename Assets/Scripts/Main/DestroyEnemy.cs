using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public int EnemyHP;
    [SerializeField]
    private GameObject effectPrefab;

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
            }


            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
