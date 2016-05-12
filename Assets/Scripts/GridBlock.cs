using UnityEngine;
using System.Collections;

public class GridBlock : MonoBehaviour {
	public GameObject AnchorPoint;
	public GameObject PrefabToSpawn;
	
	private GameObject AttachedBlock = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

public void ReactToMouseClick()
	{
        if (UIController.ButtonClick)
        {
            // Is there already a block?
            if (AttachedBlock != null)
            {
                GameObject.Destroy(AttachedBlock);
                AttachedBlock = null;
                GameController.Instance.PlacedBlocks -= 1;

            }
            else
            {
                // spawn the new prefab
                AttachedBlock = GameObject.Instantiate(PrefabToSpawn);

                // Position the prefab at the anchor point
                AttachedBlock.transform.position = AnchorPoint.transform.position;
                AttachedBlock.transform.SetParent(AnchorPoint.transform);
                GameController.Instance.PlacedBlocks += 1;
            }
        }

    }
}
