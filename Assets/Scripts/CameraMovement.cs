using UnityEngine;
public class CameraMovement : MonoBehaviour
{
    private int cameraSpeed = 10;//Kamera h�z�.
    private void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
        //X d�zleminde saniyede 10'ar 10'ar olacak �ekilde mevcut konuma atama yap.
        //GameManager isimli bo� game objemizin i�ine att�k bu kodu.
        //Game objeji X d�zleminde s�rekli + y�nde(0,10,20,50,200...) �eklinde ilerliyor.
    }
}
