using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_move : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public GameObject panel;
    public AudioSource chet, nhay;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
            nhay.Play();
            rb.AddForce(Vector2.up * speed);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        gameOver();
    }
    void gameOver() {
        Time.timeScale = 0;
        panel.SetActive(true);
        chet.Play();
    }
}
