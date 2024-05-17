using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float MaxValue = 100;
    public float Heal = 10;
    public float closedamage = 10;
    public RectTransform valueRectTransform;
    public GameObject gameplayUI;
    public GameObject gameOverScreen;
    public GameObject HealEffect;
    public Animator animator;

    public float _currentValue = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void DealDamage(float damage)
    {
        
        _currentValue -= damage;
        if (_currentValue > 0)
        {
            animator.SetTrigger("hitted");
        }
        if (_currentValue <= 0)
        {
            PlayerIsDead();
        }
        DrawHealthBar();
    }
    public void DealDamage2(float closedamage)
    {

        _currentValue -= closedamage;
        if (_currentValue > 0)
        {
            animator.SetTrigger("hitted");
        }
        if (_currentValue <= 0)
        {
            PlayerIsDead();
        }
        DrawHealthBar();
    }
    public void AddHealth(float amount)
    {
        _currentValue += Heal;
        if(_currentValue>= MaxValue)
        {
            _currentValue = MaxValue;
        }
        HealEffect.GetComponent<ParticleSystem>().Play();
        DrawHealthBar();
    }
        private void DrawHealthBar()
    {
        valueRectTransform.anchorMax = new Vector2(_currentValue /MaxValue,1);
    }
    public void PlayerIsDead()
    {
        gameplayUI.SetActive(false);
        gameOverScreen.SetActive(true);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<FireballCaster>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
        animator.SetBool("death",true);
    }
}
