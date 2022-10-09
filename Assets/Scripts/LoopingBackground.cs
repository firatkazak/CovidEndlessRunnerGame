using UnityEngine;
public class LoopingBackground : MonoBehaviour
{
    private int backgroundSpeed = 1;//ArkaPlan�n kayma h�z�.
    public Renderer backgroundRenderer;//Background renderer'i tan�mlad�k.
    private void Update()
    {
        backgroundRenderer.material.mainTextureOffset = new Vector2(backgroundSpeed * Time.deltaTime, 0);
        //Offset: Nesnenin ba�lang�c�ndan, ayn� nesnede verilen bir eleman veya noktaya kadar olan mesafeyi g�steren bilgisayar tamsay�s�d�r.
        //Yani; arkaplan resminin ba��ndan sonuna kadar tamam�n�, X d�zleminde, backgroundSpeed h�z�nda d�nd�rece�iz.
        //�zetle; Arkaplan resmi 1 saniye de 1 kez d�necek. Background'�, da GameManager'in child objesi yapt���m�z i�in, haliyle GameManager ile haraket ediyor.
    }
}
