using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab; // Prefab for instantiating baskets
    public int numBaskets = 3; // Number of baskets to create
    public float basketBottomY = -14f; // Y position of the bottom basket
    public float basketSpacingY = 2f; // Space between baskets
    public List<GameObject> basketList; // List of baskets in the scene

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for ( int i = 0; i < numBaskets; i++ )
        {
            GameObject tBasketGO = Instantiate<GameObject>( basketPrefab );
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + ( basketSpacingY * i );
            tBasketGO.transform.position = pos;
            basketList.Add( tBasketGO );
        }   
    }

    public void AppleMissed()
    {
        // Destroy all of the falling Apples
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag( "Apple" );
        foreach ( GameObject tempGO in appleArray )
        {
            Destroy( tempGO );
        }

        // Destroy one of the baskets
        // Get the index of the last Basket in basketList
        int basketIndex = basketList.Count - 1;
        // Get a reference to that Basket GameObject
        GameObject basketGO = basketList[ basketIndex ];
        // Remove the Basket from the List and destroy the GameObject
        basketList.RemoveAt( basketIndex );
        Destroy( basketGO );

        // If there are no more baskets, restart the game
        if ( basketList.Count == 0 )
        {
            SceneManager.LoadScene( "SampleScene" );
        }
    }
}
