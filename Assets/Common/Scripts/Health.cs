using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    private int _health = 1;

    public int maxHealth = 1;

    public GameObject deathVfx;

    public UnityEvent deathAction;
    
    private void Start()
    {
        _health = maxHealth;
    }

    public void Damage(int value)
    {
        _health -= value;
        if(_health <= 0) Die();
    }

    public void AddHealth(int value)
    {
        _health += value;
        _health = _health > maxHealth ? maxHealth : _health;
    }
    
    private void Die()
    {
        deathAction.Invoke();
        if(deathVfx != null)
            Instantiate(deathVfx, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
