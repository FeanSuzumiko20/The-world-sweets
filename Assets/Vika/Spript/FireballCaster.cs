using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public float damage = 10;
    public Fireball fireballPrefab;
    public Transform fireballSourceTransform;
    public Animator animator;
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var FireBall =Instantiate(fireballPrefab, fireballSourceTransform.position, fireballSourceTransform.rotation);
            FireBall.damage = damage;
            animator.SetTrigger("attack");
            
        }
        
    }
}
