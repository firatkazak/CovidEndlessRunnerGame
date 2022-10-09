using UnityEngine;
public class VirusSpawner : MonoBehaviour
{
    public GameObject coronaVirus;//Corona Virüs için game objesi tanýmladýk.
    public float minX, minY, maxX, maxY;//Virüs'ün spawnlanacaðý min ve max deðerler.
    private float timeBetweenSpawn = 1f;//Spawn aralýðý.
    private float spawnTime;//Spawn zamaný.
    private void Update()
    {
        if (Time.time > spawnTime)//Mevcut zaman spawnlanan zamandan büyükse;
        {
            Spawn();//Spawn fonksiyonunu çalýþtýr.
            spawnTime = Time.time + timeBetweenSpawn;//Mevcut zamana 1 sn(timeBetweenSpawn) ekle ve spawnTime'a ata.
            //Mantýk: Oyun baþladý 1 saniye geçti. mevcut süre 1 saniyeden büyük. haliyle 1 tane virüs spanwlanacak.
            //Sonra mevcut süre+1 saniyeyi spawnTime'a atadýk. Oyundan 2 saniye geçti. spanwTime 1 saniye idi.
            //Böylelikle her 1 saniyede 1 virüs spanwlanacak.
        }
    }
    private void Spawn()
    {
        float randomX = Random.Range(minX, maxX);//X'i minX ve maxX aralýðýnda random olarak atadýk.
        float randomY = Random.Range(minY, maxY);//Y'yi minY ve MaxY aralýðýnda random olarak atadýk. 
        Instantiate(coronaVirus,transform.position + new Vector3(randomX,randomY,0),transform.rotation);
        //Random X ve Y aralýðýnda, hep ayný açýda, corona virüs spawn et.
    }
}
