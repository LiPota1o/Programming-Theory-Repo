using UnityEngine;

public abstract class weapon : MonoBehaviour
{
    public abstract void Shoot();

    // ����������� ����������� ��� ���� ����� ������
    public void Reload()
    {
        Debug.Log("Reloading...");
    }
}
