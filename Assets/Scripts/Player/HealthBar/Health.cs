using UnityEngine;
using UnityEngine.UI;

namespace Player.HealthBar
{
    public class Health : MonoBehaviour
    {

        public Slider healthSlider;

        public void SetMaxHealth(int health)
        {
            this.healthSlider.maxValue = health;
        }
        public void SetHealth(int health)
        {
            this.healthSlider.value = health;
        }
    }
}
