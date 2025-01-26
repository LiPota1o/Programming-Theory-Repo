using UnityEngine;

public abstract class weapon : MonoBehaviour
{
    public abstract void Shoot();

    // Standard reload for all weapons
    public void Reload()
    {
        Debug.Log("Reloading...");
    }
}
