using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class AttackUIEvent : MonoBehaviour
{
    public Image damage_Image;
    public Color flash_Color;
    public float flash_Speed = 5;
    bool damaged = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0))
        {
            TakeDamage();
        }*/

        PlayDamagedEffect();

    }
	// 角色受伤后的屏幕效果
	void PlayDamagedEffect()
    {
       
        if (damaged)
        {
            damage_Image.color = flash_Color;
            Debug.Log("attack_ui damaged :" + damaged);
            damaged = false;
        }
        else
        {
            damage_Image.color = Color.Lerp(damage_Image.color, Color.clear, flash_Speed * Time.deltaTime);

        }
       

    }
    // 角色受伤
    public void TakeDamage()
    {
        damaged = true;
        Debug.Log("attack_ui damaged :" + flash_Color);

    }


}
