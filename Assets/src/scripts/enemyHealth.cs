using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
    [SerializeField]
    private int HealthPoints;
    private int MinHP = 0;
    private int MaxHP = 100;
    private Targeting targeting;


    // Use this for initialization
    void Start () {
        Targeting targeting = GetComponent<Targeting>();
        HealthPoints = MaxHP;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            HealthPoints -= 50;
        }
        if (HealthPoints <= MinHP)
        {
            Destroy(gameObject);
        }
	}
}
