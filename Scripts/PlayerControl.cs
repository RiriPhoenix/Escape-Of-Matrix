using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject camera;
    public GameObject cam2;

    public float velocidade = 20; // pode mudar depois

    Animator myAnimator;
    int Idle;

    void Start() // Start is called before the first frame update
    {
        myAnimator = gameObject.GetComponent<Animator>();
        Idle = 1;
    }

    void Update() // Update is called once per frame
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);

            myAnimator.SetInteger("Idle", 5);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.left * velocidade * Time.deltaTime);

            myAnimator.SetInteger("Idle", 4);
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);

            myAnimator.SetInteger("Idle", 3);
        }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);

            myAnimator.SetInteger("Idle", 2);
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("door1in"))
        {
            camera.transform.position = new Vector3(-200f, -109f, -20);
            Camera.main.orthographicSize = 38;
            transform.position = new Vector3(-196.7f, -89.2f, 0);
        }
        if (col.CompareTag("door1out"))
        {
            camera.transform.position = new Vector3(-39.7f, -39.8f, -20);
            Camera.main.orthographicSize = 38;
            transform.position = new Vector3(-51, -32, 0);
        }

        if (col.CompareTag("door2_in"))
        {
            camera.transform.position = new Vector3(-196.8f, 44f, -20);
            Camera.main.orthographicSize = 45;
            transform.position = new Vector3(-197.1f, 11.7f, 0);
        }
        if (col.CompareTag("door2_out"))
        {
            camera.transform.position = new Vector3(0, 0, -10);
            Camera.main.orthographicSize = 38;
            transform.position = new Vector3(-17.5f, 27.1f, 0);
        }

        if (col.CompareTag("door3_in"))
        {
            camera.transform.position = new Vector3(238f, 41.2f, -20);
            Camera.main.orthographicSize = 35;
            transform.position = new Vector3(238.1f, 8.6f, 0);
        }
        if (col.CompareTag("door3_out"))
        {
            camera.transform.position = new Vector3(0, 0, -10);
            Camera.main.orthographicSize = 38;
            transform.position = new Vector3(36.2f, 29.5f, 0);
        }
    }
}
