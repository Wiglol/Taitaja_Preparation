using UnityEngine;

public class OnScreenDebugText : MonoBehaviour
{
    [TextArea] public string text = ""Debug..."";

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 1000, 400), text);
    }
}