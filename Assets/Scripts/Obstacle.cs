using UnityEngine;
public class Obstacle : MonoBehaviour
{
    private GameObject player;//Player'i ataca��m�z game obje.
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //Player'in tag'� Player. Bu �ekilde atama yapt�k.
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")//E�er Vir�s Border'a temas ederse;
        //Oyunda Border ad�nda i�ine Collider ekledi�imiz g�r�nmez objeler yaratt�k.
        //Bu border'a temas edince vir�s destroy edilecek. Ekranda y�zlerce vir�s olmamas� i�in.
        {
            Destroy(this.gameObject);
            //Bu(Vir�s) nesneyi yok et.
        }
        else if (collision.tag == "Player")//E�er Player'a temas ederse;
        {
            Destroy(player.gameObject);//Player'i yok et.
        }
    }
}
