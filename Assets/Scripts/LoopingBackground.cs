using UnityEngine;
public class LoopingBackground : MonoBehaviour
{
    private int backgroundSpeed = 1;//ArkaPlanýn kayma hýzý.
    public Renderer backgroundRenderer;//Background renderer'i tanýmladýk.
    private void Update()
    {
        backgroundRenderer.material.mainTextureOffset = new Vector2(backgroundSpeed * Time.deltaTime, 0);
        //Offset: Nesnenin baþlangýcýndan, ayný nesnede verilen bir eleman veya noktaya kadar olan mesafeyi gösteren bilgisayar tamsayýsýdýr.
        //Yani; arkaplan resminin baþýndan sonuna kadar tamamýný, X düzleminde, backgroundSpeed hýzýnda döndüreceðiz.
        //Özetle; Arkaplan resmi 1 saniye de 1 kez dönecek. Background'ý, da GameManager'in child objesi yaptýðýmýz için, haliyle GameManager ile haraket ediyor.
    }
}
