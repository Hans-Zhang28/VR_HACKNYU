using UnityEngine;
using System.Collections;

public class FoodManager : MonoBehaviour {
    public Transform[] spawnPoints;
    public Rigidbody[] foods;

    public float spawnForce;
    public float spawnTime;
    private GameObject healthyFoodReference;
	private GameObject junkFoodReference;
	private Vector3 throwForce = new Vector3(0, 18, 0);

    private Transform camPos;
    Rigidbody foodInstance;

    // Use this for initialization
    void Start () {
        camPos = GameObject.FindGameObjectWithTag("MainCamera").transform;
        InvokeRepeating("SpawnFood", 0.5f, 6);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void OnEnable () {
        InvokeRepeating("SpawnFood", spawnTime, spawnTime);
    }
    //spawnPos.position = new Vector3(Random.Range(-100, 100),0, 75);

	void SpawnFood () {
    	for (byte i = 0; i < 4; i++) {
            int indicator = Random.Range(0, foods.Length);
            //foods = Instantiate(foods[indicator], ,) as Rigidbody;

            //foodInstance.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);
        }
	}

    // void SpawnAsteroid()
    // {
    //     int aid = Random.Range(0, asteroids.Length);

    //     int spid = Random.Range(0, spawnPoints.Length);
    //     Transform spawnPos = spawnPoints[spid];
    //     spawnPos.position = new Vector3(Random.Range(-100, 100),
    //                                     0,
    //                                     75);
    //     asteroidInstance = Instantiate(asteroids[aid], spawnPos.position, spawnPos.rotation) as Rigidbody;

        
    //     asteroidInstance.transform.LookAt(camPos);
    //     //asteroidInstance.velocity = spawnForce * (-transform.forward+transform.up);

    //     asteroidInstance.velocity = spawnForce * (camPos.position- spawnPos.position).normalized;
    // }
}
