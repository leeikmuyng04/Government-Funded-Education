using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] GameObject [] weapons;
    [SerializeField] List<GameObject> weaponList;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Equip();
        }
    }

    public void Equip()
    {
        if(weapons.Length <= count)
        {
            return;
        }

        GameObject clone = Instantiate(weapons[count++]);

        clone.gameObject.SetActive(false);

        weaponList.Add(clone);
    }

}
