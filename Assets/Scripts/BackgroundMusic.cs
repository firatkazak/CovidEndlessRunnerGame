using UnityEngine;
public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;
    private void Awake()
    {
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
            Destroy(gameObject);
    }
}
//Singleton ile Background m�zi�i s�rekli �al���r hale getirdik.