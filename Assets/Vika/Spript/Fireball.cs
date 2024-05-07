using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float damage = 10;
    

    private void Start()
    {
        Invoke("DestroyFireball", lifetime);
    }
    
    void FixedUpdate()
    {
        MoveFixedUpdate();
    }
   
    void DestroyFireball()
    {
        Destroy(gameObject);
    }

    void MoveFixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }

   private void OnCollisionEnter(Collision collision)
    {
        DestroyFireball();
        DamageEnemy(collision);
    }
    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
        DestroyFireball();
    }

}
