using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {
    
   // public scoremanager ScoreManager;
   // private int val=100;
    // Use this for initialization
    
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //ScoreManager.AddPoints(val);
            Destroy(gameObject);
        }
    }

}
