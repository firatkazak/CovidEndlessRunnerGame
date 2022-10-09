using UnityEngine;
public class Obstacle : MonoBehaviour
{
    private GameObject player;//Player'i atacaðýmýz game obje.
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //Player'in tag'ý Player. Bu þekilde atama yaptýk.
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")//Eðer Virüs Border'a temas ederse;
        //Oyunda Border adýnda içine Collider eklediðimiz görünmez objeler yarattýk.
        //Bu border'a temas edince virüs destroy edilecek. Ekranda yüzlerce virüs olmamasý için.
        {
            Destroy(this.gameObject);
            //Bu(Virüs) nesneyi yok et.
        }
        else if (collision.tag == "Player")//Eðer Player'a temas ederse;
        {
            Destroy(player.gameObject);//Player'i yok et.
        }
    }
}
