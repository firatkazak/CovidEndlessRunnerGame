using TMPro;
using UnityEngine;
public class ScoreManager : MonoBehaviour
{
    public float score;//Skoru tutaca��m�z de�i�ken.
    public TextMeshProUGUI scoreText;//Skor texti i�in.
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)//E�er Player null de�il ise(Yani player aktif ise)
        {
            score += 1 * Time.deltaTime;//Her ge�en saniye s�reye 1 ekle.
            //Hayatta kald���m�z s�re bizim skorumuz olacak. �rn, 20 saniye �lmedik, skor 20 olacak.
            scoreText.text = ((int)score).ToString();
            //Skoru string'e �evir, SkoreText'e ata.
        }
    }
}
