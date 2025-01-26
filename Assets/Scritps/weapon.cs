using UnityEngine;

public abstract class weapon : MonoBehaviour
{
    public abstract void Shoot();

    // —тандартна€ перезар€дка дл€ всех видов оружи€
    public void Reload()
    {
        Debug.Log("Reloading...");
    }
}
