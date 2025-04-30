using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;
    [SerializeField] List<GameObject> weaponsList;
    [SerializeField] Transform parentPosition;
    [SerializeField] int count = 0;

    private int number = 0;

    void Start()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            //weaponsList[i] = Instantiate(weapons[i], parentPosition);
            GameObject clone = Instantiate(weapons[i], parentPosition);
            clone.gameObject.SetActive(false);

            weaponsList.Add(clone);
        }

        weaponsList[number].SetActive(true);
        //weaponsList[number].gameObject.SetActive(true);
    }

    private void Update()
    {
        //Input.GetKeyDown(KeyCode.Space) µµ °¡´É
        if (Input.GetButtonDown("Jump"))
        {
            Swap();
        }

        if (Input.GetMouseButtonDown(0))  // 0 ¿Þ, 1 ¿À
        {
            Attack();
            //Knife knife = new Knife();
            //knife.Attack();
        }
    }

    public void Swap()
    {
        weaponsList[number].SetActive(false);
        number++;
        if (number >= weaponsList.Count) { number = 0; }
        weaponsList[number].SetActive(true);

        //weaponsList[count].gameObject.SetActive(false);
        //count = (count + 1) % weaponsList.Count;
        //weaponsList[count].gameObejct.SetActive(true);
    }

    public void Attack()
    {
        weaponsList[number].GetComponent<Weapon>().Attack();
    }
}