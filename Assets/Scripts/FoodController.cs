using UnityEngine;
using System.Collections;

public class FoodController : MonoBehaviour {
    public float speed;
    private Transform camPos;
    // public float lifeAfterHit;

    // private PlayerHealth playerhealth;
    private bool hitCam;
    private Vector3 direction;
    private Vector3 rotateDir;
    private GameManager gm;
    private int score;

	// Use this for initialization
	void Start () {
        camPos = GameObject.FindGameObjectWithTag("MainCamera").transform;
        // playerhealth = GameObject.Find("PlayerManager").GetComponent<PlayerHealth>();

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rotateDir = new Vector3(15, 35, 30);
        direction = (camPos.position - transform.position).normalized;
        //lifeAfterHit = 2f;
        speed = 10f;
        hitCam = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.y < -36) {
        	Destroy(gameObject);
    	}
	}
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            hitCam = true;
            // playerhealth.GotHit();
            // HitPlayer();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Hand")
        {
            gm.AddScore(score);
        }
    }

   

    // void HitPlayer()
    // {
    //     //Debug.Log("Hit camera!");
    //     Invoke("DestroyAsteroid", lifeAfterHit);
    // }

    void DestroyAsteroid()
    {
        Destroy(gameObject);
    }
}
