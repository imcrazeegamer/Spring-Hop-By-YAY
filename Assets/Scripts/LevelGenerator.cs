using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    [SerializeField]
	private GameObject platformPrefab;

    [SerializeField]
    private float levelWidth = 3f;
    [SerializeField]
    private float minY = .2f;
    [SerializeField]
    private float maxY = 1.5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Platform")
        {
            //Debug.Log("Platform off Screen");
            CreatePlatform();
            Destroy(collision.gameObject);
        }
           
    }

    private void CreatePlatform() {
        GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");
        float maxdis = platforms.ToList().Max((p) => p.transform.position.y);
        Vector3 spawnPosition = platforms.ToList().Where((p) => p.transform.position.y == maxdis).ToList()[0].transform.position;
        Quaternion rotate = Quaternion.Euler(0, 0, 90);
        spawnPosition.y += Random.Range(minY, maxY);
	    spawnPosition.x = Random.Range(-levelWidth, levelWidth);
		Instantiate(platformPrefab, spawnPosition, rotate);
		
	}
}
