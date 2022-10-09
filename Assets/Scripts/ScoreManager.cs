using TMPro;
using UnityEngine;
public class ScoreManager : MonoBehaviour
{
    public float score;//Skoru tutacaðýmýz deðiþken.
    public TextMeshProUGUI scoreText;//Skor texti için.
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)//Eðer Player null deðil ise(Yani player aktif ise)
        {
            score += 1 * Time.deltaTime;//Her geçen saniye süreye 1 ekle.
            //Hayatta kaldýðýmýz süre bizim skorumuz olacak. örn, 20 saniye ölmedik, skor 20 olacak.
            scoreText.text = ((int)score).ToString();
            //Skoru string'e çevir, SkoreText'e ata.
        }
    }
}
