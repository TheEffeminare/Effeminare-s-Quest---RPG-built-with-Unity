// Anwesh Kumar Sahoo
// Written with Love Light and Rainbows
// Student ID 123103755

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton2D : MonoBehaviour
{
    // Name of the scene to load when the button is clicked
    [SerializeField] private string sceneToLoad = "MainScene1960s";

    void Update()
    {
        // Detect if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in world coordinates
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Perform a 2D raycast at the mouse position
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // Check if the raycast hit this game object's collider
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                // Optional: Check if the GameObject's name is "RubyShoes"
                if (hit.collider.gameObject.name == "RubyShoes")
                {
                    OnButtonClick();
                }
            }
        }
    }

    // Method called when the button is clicked
    private void OnButtonClick()
    {
        Debug.Log("RubyShoes clicked!");
        // Load the scene called "MainScene1960s"
        SceneManager.LoadScene(sceneToLoad);
    }
}
