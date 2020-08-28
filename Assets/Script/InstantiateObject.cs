using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject targetEnemy;
    //生成怪物的總數量
    public int enemyTotalNum = 20;
    //生成怪物的時間間隔
    public float intervalTime = 2;
    //生成怪物的計數器
    private int enemyCounter;

    // Start is called before the first frame update
    void Start()
    {
        //初始時，怪物計數爲0；
        enemyCounter = 0;
        //重複生成怪物
        InvokeRepeating("CreatEnemy", 0.5F, UnityEngine.Random.Range(2, 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //方法，生成怪物
    private void CreatEnemy()
    {
        
            //生成一隻怪物
            Instantiate(targetEnemy, new Vector3(UnityEngine.Random.Range(-1.5f,2f),4, UnityEngine.Random.Range(-1.5f, 1.5f)) , targetEnemy.transform.rotation);
            enemyCounter++;
            //如果計數達到最大值
            /*if (enemyCounter == enemyTotalNum)
            {
                //停止刷新
                CancelInvoke();
            }*/
        
       
    }
}
