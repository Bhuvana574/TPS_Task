using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    int startHealth = 5;
    [SerializeField]
    int currentHealth;
    private void OnEnable()
    {
        currentHealth = startHealth;
    }
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        //gameObject.SetActive(false);
        Destroy(this.gameObject);
        if (this.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}