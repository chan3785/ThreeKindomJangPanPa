using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private int hp, atk, subHp;
    private float atkSpeed = 1,timer;
    public int walkSpeed;

    private bool inaction;

    Rigidbody2D rigid;
    Animator ani;

    
    
    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }

    public int Atk
    {
        get { return hp; }
        set { hp = value; }
    }

    public int SubHp
    {
        get { return subHp; }
        set { subHp = value; }
    }

    private void walk()
    {
        transform.Translate(new Vector3(-walkSpeed * Time.deltaTime, 0, 0));
    }

    private void hurt()
    {
        Debug.Log("enemy hurt");
    }

    private void dead()
    {

    }

    private void Attack()
    {



        ani.SetBool("Atk", true);
       

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            if (Player.is_atk)
            {
                hurt();
                Player.is_atk = false;
            }
        }
    }
   


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        
        

        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (transform.position.x > -5)
        {
            walk();
            
            
        }
        else
        {
            if(timer >= atkSpeed) {
                
                Attack();
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }
}
