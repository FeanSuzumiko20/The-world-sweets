using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    public float MaxValue = 100;
   
    public Animator animator;
    public int EnemyCount = 0;
    public EnemyAI enemy;
    

    public bool IsAlive()
    {
        return _currentValue > 0;
    }

     public float _currentValue =100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void DealDamage(float damage)
    {
        
          _currentValue -= damage;
        animator.SetTrigger("hit");
        if (_currentValue <= 0)
        {
                Destroy(gameObject);
            
        }
        else
        {
            animator.SetTrigger("hitted");
        }
        
        
    }
  
    
}
