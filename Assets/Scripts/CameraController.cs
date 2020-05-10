using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //transform.position references the transform's position for the camera as they are both attached to the same game object.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
        /*
        It is worth noting that even though we are working with a 2D sprite
        we are using a vector3 to rotate the collectable's transform.
        This is because the transform of the 2D sprite still exists in the 3D volume.
        When using the transform component with 2D objects we simply ignore
        the axis we don't need.
        */
    }
}