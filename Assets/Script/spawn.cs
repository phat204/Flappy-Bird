using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class spawn : MonoBehaviour
{
    public GameObject pipe;
    public float maxTime;
    private float timer;
    public float height;
    public int numPipesSpawned = 0; // Số lượng ống đã được tạo ra
    public TextMeshProUGUI Score;
    public AudioSource qua_ong;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(pipe, new Vector3(transform.position.x, transform.position.y + Random.Range(-height, height), 0), Quaternion.identity);
            Destroy(tmp, 10f);
            timer = 0;
            numPipesSpawned++; // Tăng số lượng ống được tạo ra
            qua_ong.Play();
            Debug.Log("Number of pipes spawned: " + numPipesSpawned);
            Score.text = "" + (numPipesSpawned - 2);
        }
        timer += Time.deltaTime;    
    }
}
