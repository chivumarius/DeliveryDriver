using UnityEngine;


// ▬▬ The "Position" of the "Camera" 
//      → "Must Bbe" the "Same" 
//      → as the "Position" of the "Car" ▬▬
public class FollowCamera : MonoBehaviour
{
    // ▼ "[SerializeField]" Attribute
    //      → allow us to "View" & "Edit" 
    //      → the "Variables" 
    //      → in the "Unity Inspector" Window 
    //      → where the "Values" are "Overwritten" ▼
    [SerializeField] GameObject thingToFollow;


    // ▬ The "LateUpdate()" Built-In Method 
    //      → that is used to "Update" 
    //      → the "Position", "Rotation", 
    //      → or Other Properties 
    //      → of an "In-Game Object" 
    //      → After "All Normal Frame Updates" 
    //      → have "Taken Place" ▬
    void LateUpdate()
    {
        // ▼ "Accessing" (by "Reference") & "Overwriting" 
        //     → the "Position" of the "Main Camera" 
        //     → from the "Transform" Component
        //     → with the "Position" of the "Car" 
        //     → (wich is a "Vector3(X, Y, Z)) ▼
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);
    }

}
