using UnityEngine;

public class Health : MonoBehaviour, IDamageable
{
    public int MaxHP = 3;
    public bool destroyOnDeath = false;

    public int CurrentHP { get; private set; }

    public System.Action onDeath;
    public System.Action<int> onDamaged;

    private void Awake()
    {
        CurrentHP = MaxHP;
    }

    public void TakeDamage(int amount)
    {
        if (amount <= 0) return;

        CurrentHP -= amount;
        onDamaged?.Invoke(amount);

        if (CurrentHP <= 0)
        {
            CurrentHP = 0;
            onDeath?.Invoke();
            if (destroyOnDeath) Destroy(gameObject);
        }
    }

    public void Heal(int amount)
    {
        if (amount <= 0) return;
        CurrentHP = Mathf.Clamp(CurrentHP + amount, 0, MaxHP);
    }
}