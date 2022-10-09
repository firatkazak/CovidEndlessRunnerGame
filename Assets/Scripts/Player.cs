using UnityEngine;
public class Player : MonoBehaviour
{
    private int playerSpeed = 12;//Player'in h�z�.
    private Rigidbody2D playerRb;//Player'in Rigidbody'si.
    private Vector2 playerDirection;//Player'in y�n�.
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();//Rb atama i�lemi yapt�k.
    }
    private void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");//Vertical ��k�� ald�k.
        playerDirection = new Vector2(0, directionY).normalized;//playerDirection'� X'te 0, y'de vertical ��k�� olacak �ekilde belirttik.
        playerRb.velocity = new Vector2(0, playerDirection.y * playerSpeed);//12 birim h�zda a�a�� yukar� inip ��kabilece�iz.
        //Rb'nin velocity'sine playerSpeed h�z�nda playerDirection'un Y'si �eklinde bir atama yapt�k.
    }
}
