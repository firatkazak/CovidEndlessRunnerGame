using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;//Game over panelimizi ataca��m�z game obje.
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)//Player null ise;
        //Obstacle scriptinde(Vir�s) e�er vir�s player'e �arparsa player'i destroy et dedik.
        //Player destroy edilirse haliyle null olur.
        {
            gameOverPanel.SetActive(true);
            //Null olunca da haliyle oyun biter, game over panelini aktif ederiz.
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Restart'a bas�nca mevcut oyun sahnemiz aktif edilir.
        //Ba�lang��ta game over panelimiz kapal� oldu�u i�in o halde sahneye ge�ilir.
    }
}

