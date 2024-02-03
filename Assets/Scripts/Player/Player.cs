using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 1;
    public int experience = 0;
    public int maxHealth = 20;
    public int currentHealth = 20;

    public string currentWeapon = "trident";
    public string currentItem = "sheild charm";

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(2);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
