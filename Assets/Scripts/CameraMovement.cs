using UnityEngine;
public class CameraMovement : MonoBehaviour
{
    private int cameraSpeed = 10;//Kamera hýzý.
    private void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
        //X düzleminde saniyede 10'ar 10'ar olacak þekilde mevcut konuma atama yap.
        //GameManager isimli boþ game objemizin içine attýk bu kodu.
        //Game objeji X düzleminde sürekli + yönde(0,10,20,50,200...) þeklinde ilerliyor.
    }
}
