using UnityEngine;
public class VirusSpawner : MonoBehaviour
{
    public GameObject coronaVirus;//Corona Vir�s i�in game objesi tan�mlad�k.
    public float minX, minY, maxX, maxY;//Vir�s'�n spawnlanaca�� min ve max de�erler.
    private float timeBetweenSpawn = 1f;//Spawn aral���.
    private float spawnTime;//Spawn zaman�.
    private void Update()
    {
        if (Time.time > spawnTime)//Mevcut zaman spawnlanan zamandan b�y�kse;
        {
            Spawn();//Spawn fonksiyonunu �al��t�r.
            spawnTime = Time.time + timeBetweenSpawn;//Mevcut zamana 1 sn(timeBetweenSpawn) ekle ve spawnTime'a ata.
            //Mant�k: Oyun ba�lad� 1 saniye ge�ti. mevcut s�re 1 saniyeden b�y�k. haliyle 1 tane vir�s spanwlanacak.
            //Sonra mevcut s�re+1 saniyeyi spawnTime'a atad�k. Oyundan 2 saniye ge�ti. spanwTime 1 saniye idi.
            //B�ylelikle her 1 saniyede 1 vir�s spanwlanacak.
        }
    }
    private void Spawn()
    {
        float randomX = Random.Range(minX, maxX);//X'i minX ve maxX aral���nda random olarak atad�k.
        float randomY = Random.Range(minY, maxY);//Y'yi minY ve MaxY aral���nda random olarak atad�k. 
        Instantiate(coronaVirus,transform.position + new Vector3(randomX,randomY,0),transform.rotation);
        //Random X ve Y aral���nda, hep ayn� a��da, corona vir�s spawn et.
    }
}
