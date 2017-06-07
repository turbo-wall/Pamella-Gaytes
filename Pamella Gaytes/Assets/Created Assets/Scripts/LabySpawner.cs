using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class LabySpawner : MonoBehaviour
{
	[SerializeField]
	int random;

    public GameObject player;
	void Start()
	{
        random = Random.Range(1, 5);
        


        switch (random) 
		{
		case 1:
                player.transform.position = new Vector3(-161.4f, 2f, 99.9f);
                
                break;
		case 2:
                player.transform.position = new Vector3(-102f, 2f, 94.2f);
                break;
		case 3:
                player.transform.position = new Vector3(129.56f, 2f, -91.2f);
                break;
		case 4:
                player.transform.position = new Vector3(254.6f, 2f, -256.4f);
                break;
		case 5:
                player.transform.position = new Vector3(563.8f, 2f, -337.55f);
                break;
            default:
                player.transform.position = new Vector3(563.8f, 2f, -337.55f);
                break;

        }


	}
}
