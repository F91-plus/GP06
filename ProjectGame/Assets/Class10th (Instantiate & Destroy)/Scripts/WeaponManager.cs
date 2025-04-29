using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject [] weapons;
    [SerializeField] List<GameObject> weaponsList;

    //create posistion
    [SerializeField] Transform parentPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(prefab, parentPosition);//object, parant posistion

        for (int i = 0; i < weapons.Length; i++) 
        {
            weaponsList[i] = Instantiate(weapons[i], parentPosition);
        }
    }

    private void Update()
    {
        //Input.GetAxis("Jump")
        //if ()
        //{

        //}
    }

}