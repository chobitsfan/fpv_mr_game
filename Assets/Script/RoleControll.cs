using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleControll : MonoBehaviour
{
    public GameObject thirdPersonPlayer;  //角色
    public float MoveSpeed = 1;       //移动速度
    public float RotateSpeed = 20.0f;     //旋转速度

    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {

        //移動

        if (Input.GetKey(KeyCode.W))

        {

            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);

        }

        else if (Input.GetKey(KeyCode.S))

        {

            transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed);

        }

        //旋轉

        if (Input.GetKey(KeyCode.D))

        {

            transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed);

        }

        else if (Input.GetKey(KeyCode.A))

        {

            transform.Rotate(Vector3.down * Time.deltaTime * RotateSpeed);

        }
        //上键上升
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * MoveSpeed);
        }
        //下键下降
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * MoveSpeed);
        }
        /*
        Vector3 pos = transform.position;

        //w键前进
        if (Input.GetKey(KeyCode.W))
        {
            pos.z += MoveSpeed;
            transform.position = pos;
        }
        //s键后退
        if (Input.GetKey(KeyCode.S))
        {
            pos.z -= MoveSpeed;
            transform.position = pos;
        }
        //a键左移
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= MoveSpeed;
            transform.position = pos;
        }
        //d键右移
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += MoveSpeed;
            transform.position = pos;
        }
        //上键上升
        if (Input.GetKey(KeyCode.UpArrow))
        {           
            pos.y += MoveSpeed;
            transform.position = pos;
        }
        //下键下降
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= MoveSpeed;
            transform.position = pos;
        }
        //q键左轉
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0,-2, 0));
        }
        //e键右轉
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 2, 0));
        }*/

    }
}