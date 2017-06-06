using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class LabySpawner : MonoBehaviour
{
	[SerializeField]
	int random;
    
    public GameObject _NetworkManager;
	void Start()
	{
        random = Random.Range(1, 5);
        


        switch (random) 
		{
		case 1:
                _NetworkManager.transform.position = new Vector3(-161.4f, 2f, 99.9f);
                
                break;
		case 2:
                _NetworkManager.transform.position = new Vector3(-102f, 2f, 94.2f);
                break;
		case 3:
                _NetworkManager.transform.position = new Vector3(129.56f, 2f, -91.2f);
                break;
		case 4:
                _NetworkManager.transform.position = new Vector3(254.6f, 2f, -256.4f);
                break;
		case 5:
                _NetworkManager.transform.position = new Vector3(563.8f, 2f, -337.55f);
                break;
            default:
                _NetworkManager.transform.position = new Vector3(563.8f, 2f, -337.55f);
                break;

        }


	}
}
