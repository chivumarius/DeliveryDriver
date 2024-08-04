using UnityEngine;

public class Delivery : MonoBehaviour
{
     // ▼ "Changing Colors" for the "Car"/"Cruisy McDrive" 
    //      → after "Picking Up" the "Package" 
    //      → and "Delivering" the "Package" ▼
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    // ▼ "SerializeField" to "Show" in "Inspector" ("0.5 Seconds") ▼
    [SerializeField] float destroyDelay = 0.5f;
   

    // ▼ "Variable" ▼
    bool hasPackage;
   

    // ▼ "Storinh" the "SpriteRenderer" ▼
    SpriteRenderer spriteRenderer;



    // ▬ "Start()" Built-in Method 
    //      →  to "Initialize" 
    //      →  the "Car"/"Cruisy McDrive" 
    //      →  and "Set" the "Color" of the "Car" ▬
    void Start()
    {
        // ▼ "Storinh" the "SpriteRenderer" 
        //      →  in which we "Get Component" ▼
       spriteRenderer = GetComponent<SpriteRenderer>();  
    }




    // ▬ "OnCollisionEnter2D()" Built-in Method 
    //      →  to "Detect Collision" 
    //      →  between "2 Objects" ▬
    void OnCollisionEnter2D(Collision2D other)
    {
        // ▼ "Printing" to "Console" ▼
        Debug.Log("I collided with something!");
    }


    // ▬ "OnTriggerEnter2D()" Built-in Method 
    //      → to "Detect"
    //      → when an "Object" enters 
    //      → a "2D Trigger" 
    //      → and allow "Defining Specific Actions" ▬
    void OnTriggerEnter2D(Collider2D other) 
    {   
        // ▼ Set "Tag" as "Package" ▼
        if (other.tag == "Package" && !hasPackage)
        {
            // ▼ "Printing" to "Console" ▼
            Debug.Log("Package Picked Up");

            // ▼ "Set" ▼
            hasPackage = true;

            
            // ▼ "Changing Colors" for the "Car"/"Cruisy McDrive" 
            //      → after "Picking Up" the "Package" 
            //      → and "Delivering" the "Package" ▼
            spriteRenderer.color = hasPackageColor;


            // ▼ "Calling" the "Distry" Method
            //      → to "Destroy"/"Remove" the "Game Object" 
            //      → from the "Scene" in "0.5 Seconds" ▼
            Destroy(other.gameObject, destroyDelay);
        }



        // ▼ Set "Tag" as "Customer" ▼
        if (other.tag == "Customer" && hasPackage)
        {
            // ▼ "Printing" to "Console" ▼
            Debug.Log("Package Delivered");


            // ▼ "Set" ▼
            hasPackage = false;


            // ▼ "Changing Colors" for the "Car"/"Cruisy McDrive" 
            //      → after "Picking Up" the "Package" 
            //      → and "Delivering" the "Package" ▼
            spriteRenderer.color = noPackageColor;
        }
    }
}