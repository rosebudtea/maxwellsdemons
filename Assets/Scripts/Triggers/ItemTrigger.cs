using UnityEngine;

public class ItemTrigger : MonoBehaviour
{
    public Item item;

    public void PickUpItem()
    {
        Debug.Log("Picked Up Item: " + item.name);
        // Add to inventory
        Inventory.instance.Add(item);
        // Remove object from scene
        Destroy(gameObject);
    }
}
