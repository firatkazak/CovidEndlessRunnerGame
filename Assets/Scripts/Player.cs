using UnityEngine;
public class Player : MonoBehaviour
{
    private int playerSpeed = 12;//Player'in hýzý.
    private Rigidbody2D playerRb;//Player'in Rigidbody'si.
    private Vector2 playerDirection;//Player'in yönü.
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();//Rb atama iþlemi yaptýk.
    }
    private void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");//Vertical çýkýþ aldýk.
        playerDirection = new Vector2(0, directionY).normalized;//playerDirection'ý X'te 0, y'de vertical çýkýþ olacak þekilde belirttik.
        playerRb.velocity = new Vector2(0, playerDirection.y * playerSpeed);//12 birim hýzda aþaðý yukarý inip çýkabileceðiz.
        //Rb'nin velocity'sine playerSpeed hýzýnda playerDirection'un Y'si þeklinde bir atama yaptýk.
    }
}
