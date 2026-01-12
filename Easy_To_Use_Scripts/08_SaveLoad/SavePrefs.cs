using UnityEngine;

public static class SavePrefs
{
    public static void SaveInt(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
        PlayerPrefs.Save();
    }

    public static int LoadInt(string key, int def = 0)
    {
        return PlayerPrefs.GetInt(key, def);
    }
}