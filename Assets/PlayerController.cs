using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 10;
    public Rigidbody rigibody;
    public GameObject gameOverText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigibody.AddForce(new Vector3(0, 0, 1) * power);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rigibody.AddForce(new Vector3(0, 0, -1) * power);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigibody.AddForce(new Vector3(-1, 0, 0) * power);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigibody.AddForce(new Vector3(1, 0, 0) * power);
        }

        //プレイヤーが落ちたら死亡させる
        if(transform.position.y < 0)
        {
            Destroy(gameObject);
            //gameoverテキストを表示
            gameOverText.SetActive(true);
        }
    }
}
