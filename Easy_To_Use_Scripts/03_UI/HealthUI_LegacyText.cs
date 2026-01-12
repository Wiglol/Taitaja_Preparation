using UnityEngine;
using UnityEngine.UI;

public class HealthUI_LegacyText : MonoBehaviour
{
    public Text text;
    public Health target;

    private void Update()
    {
        if (text && target) text.text = $""HP: {target.CurrentHP}/{target.MaxHP}"";
    }
}