using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerHP;

    public float moveSpeedRate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            playerHP -= 1;

            Destroy(other.gameObject);

            if (playerHP < 0)
            {
                Destroy(gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(horizontal / moveSpeedRate, 0, 0);
    }
}
