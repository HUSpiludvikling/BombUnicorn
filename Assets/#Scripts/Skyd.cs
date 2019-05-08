using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyd : MonoBehaviour
{
    public GameObject Bullet;
    public KeyCode FireKey;
    [SerializeField] bool facingRight = true;
    SpriteRenderer playerSR;


    private float speed =9f;

    // Start is called before the first frame update
    void Start()
    {
        playerSR = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {

        facingRight = !playerSR.flipX;
        
        if (Input.GetKeyDown(FireKey))
        {
            GameObject temp;

            temp = Instantiate(Bullet, transform.position + (facingRight ? Vector3.right : Vector3.left) + Vector3.up, Quaternion.identity);
            temp.GetComponent<Rigidbody2D>().AddForce((facingRight ? Vector2.right : Vector2.left) * speed, ForceMode2D.Impulse);
            Destroy(temp, 5f);
        }
    }
}
