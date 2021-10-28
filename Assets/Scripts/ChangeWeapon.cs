using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    [SerializeField] private GameObject knife;
    [SerializeField] private GameObject pistol;
    [SerializeField] private GameObject sniperWeapon;

    private void Start()
    {
        AllOff();
        knife.SetActive(true);
    }

    public void ChangeOnKnife()
    {
        AllOff();
        knife.SetActive(true);
    }

    public void ChangeOnPistol()
    {
        AllOff();
        pistol.SetActive(true);
    }

    public void ChangeOnSniperWeapon()
    {
        AllOff();
        sniperWeapon.SetActive(true);
    }

    private void AllOff()
    {
        knife.SetActive(false);
        pistol.SetActive(false);
        sniperWeapon.SetActive(false);
    }
}
