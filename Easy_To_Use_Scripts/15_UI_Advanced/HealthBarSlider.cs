using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    public Health target;
    public Slider slider;

    private void Awake()
    {
        if (!slider) slider = GetComponent<Slider>();
    }

    private void Update()
    {
        if (!target || !slider) return;

        slider.maxValue = target.MaxHP;
        slider.value = target.CurrentHP;
    }
}