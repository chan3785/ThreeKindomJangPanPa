using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

   
    private int hp, atk, atkSpeed, specialSkillGage, subHp;

    public static bool is_atk;
    
   

    Animator anim;
    public int Hp
    {
        get {return hp;} 
        set { hp = value;}
    }

    public int Atk
    {
        get {return hp;}
        set { hp = value;}
    }

    public int SubHp
    {
        get { return subHp;}
        set { subHp = value;}
    }

    public int Special
    {
        get { return specialSkillGage;}
        set { specialSkillGage = value;}
    }


    private void Awake()
    {
        
            
        anim= GetComponent<Animator>();
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("1");
        if (collision.CompareTag("Player"))
        {
            Hurt();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        is_atk = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Attack1()
    {
        anim.SetBool("Atk1", true);
        is_atk = true;
        Invoke("ani_init", 0.5f);
        
    }

    private void Attack2()
    {
        anim.SetBool("Atk2", true);
        is_atk = true;
        Invoke("ani_init", 1);
        
    }

    private void Kill()
    {

    }

    private void Hurt()
    {

    }

    private void Guard()
    {
        
    }

    private void Parrying()
    {

    }

    private void ani_init()
    {
        anim.SetBool("Atk2", false);
        anim.SetBool("Atk1", false);
        //Debug.Log("1");
        is_atk= false;
    }
}
