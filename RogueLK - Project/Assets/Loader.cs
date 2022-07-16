using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    [SerializeField]
    public GameObject[] characterPrefabs;
    
    public Transform spawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacters = PlayerPrefs.GetInt("selectedCharacters");
        GameObject prefab = characterPrefabs[selectedCharacters];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        
    }
}
