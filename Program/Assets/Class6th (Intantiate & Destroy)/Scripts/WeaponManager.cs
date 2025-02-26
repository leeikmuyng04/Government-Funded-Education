using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] Weapon currentWeapon;
    [SerializeField] GameObject [] weapons;
    [SerializeField] List<GameObject> weaponList;

    [SerializeField ]bool check;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Equip();

            Shift();          
        }

        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    public void Equip()
    {
        if(check == true)
        {
            return;
        }

        if (weapons.Length <= count)
        {
            check = true;
            return;
        }

        GameObject clone = Instantiate(weapons[count++]);

        currentWeapon = clone.GetComponent<Weapon>();

        if (weaponList.Count >= 1)
        {
             weaponList[weaponList.Count-1].gameObject.SetActive(false);
        }

        clone.gameObject.SetActive(true);

        weaponList.Add(clone);
    }

    public void Shift()
    {
        if (check)
        {
            for(int i = 0; i < weaponList.Count; i++)
            {
                weaponList[i].gameObject.SetActive(false);
            }

            currentWeapon = weaponList[count % weaponList.Count].GetComponent<Weapon>();

            weaponList[count++ % weaponList.Count].gameObject.SetActive(true);
        }
    }

    public void Attack()
    {
        if (currentWeapon != null)
        {
            currentWeapon.Attack();
        }
    }
}
