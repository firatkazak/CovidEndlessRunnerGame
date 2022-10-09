using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;//Game over panelimizi atacaðýmýz game obje.
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)//Player null ise;
        //Obstacle scriptinde(Virüs) eðer virüs player'e çarparsa player'i destroy et dedik.
        //Player destroy edilirse haliyle null olur.
        {
            gameOverPanel.SetActive(true);
            //Null olunca da haliyle oyun biter, game over panelini aktif ederiz.
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Restart'a basýnca mevcut oyun sahnemiz aktif edilir.
        //Baþlangýçta game over panelimiz kapalý olduðu için o halde sahneye geçilir.
    }
}

