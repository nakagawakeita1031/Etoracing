using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int playerHP;

    public float moveSpeedRate;

    [SerializeField]
    private Text HPLabel;

    // Start is called before the first frame update
    void Start()
    {
        HPLabel.text = "HP:" + playerHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            playerHP -= 1;

            Destroy(other.gameObject);

            if (playerHP <= 0)
            {
                Destroy(gameObject);

                SceneManager.LoadScene("Result");
                
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(horizontal / moveSpeedRate, 0, 0);

        HPLabel.text = "HP:" + playerHP;
    }
}
