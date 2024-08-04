using UnityEngine;

public class Driver : MonoBehaviour
{
    // ▼ "[SerializeField]" Attribute
    //      → allow us to "View" & "Edit" 
    //      → the "Variables" 
    //      → in the "Unity Inspector" Window 
    //      → where the "Values" are "Overwritten" ▼
    [SerializeField] float steerSpeed = 1f;   
    [SerializeField] float moveSpeed = 20f;
   
    // ▼ "Slow" & "Boost" Speeds ▼
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;





    
    // ▬ It is "Called" for "Every Frame" 
    //      → the "Game Needs" to "Run" in "Every Second" ▬
    void Update()
    {
        // ▼ Calling ".GetAxis()" Method  of "Input" Class
        //      → and "Storing" in the "Variables", 
        //      → that "Needs" to be "Upgraded"/"Changed" 
        //      → to "Any Frame" per "Second" ▼
        // ▼ Calling the ".deltaTime()" Method 
        //      → of "Time" Class 
        //      → to "Set" the "Same Number" of "Frames" per "Second" 
        //      → for "Any Device" ▼
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;   // ◄◄ Move "Left" & "Right"◄◄
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;       // ◄◄ Move "Forward"  & "Backward" ◄◄



        // ▼ Calling ".Rotate(x, y, z)" Method 
        //      → of "Transform" Class 
        //      → to "Rotate" the "Cruisy McDriver" Object ▼
        transform.Rotate(0, 0, -steerAmount);


        // ▼ Calling ".Translate(x, y, z)" Method 
        //      → of "Transform" Class 
        //      → to "Move" the "Cruisy McDriver" Object 
        //      → on the "Y-Axis" ▼
        transform.Translate(0, moveAmount, 0);
    }



    // ▬ "OnCollisionEnter2D()" Built-in Method
    //      → to "Detect"
    //      → when an "Object" enters
    //      → a "2D Collision"
    //      → and allow "Defining Specific Actions" ▬
    void OnCollisionEnter2D(Collision2D other) 
    {        
        // ▼ "Set" "Slow" Speed ▼
        moveSpeed = slowSpeed; 
    }



        
    // ▬ "OnTriggerEnter2D()" Built-in Method 
    //      → to "Detect"
    //      → when an "Object" enters 
    //      → a "2D Trigger" 
    //      → and allow "Defining Specific Actions" ▬
    void OnTriggerEnter2D(Collider2D other) 
    {   
        // ▼ Set "Tag" as "Boost" ▼
        if(other.tag == "Boost")
        {
           
            // ▼ "Set" ▼
            moveSpeed = boostSpeed;  
        }        
    }
}
