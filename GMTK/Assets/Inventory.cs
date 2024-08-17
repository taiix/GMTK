using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject selector;

    [SerializeField] private Slot[] slots;

    [SerializeField] private Slot selectedSlot;

    private void Start()
    {
        selector.transform.position = slots[0].transform.position;
        selectedSlot = slots[0];
    }

    void Update()
    {
        SelectItem();
    }

    private void SelectItem()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { 
            selector.transform.position = slots[0].transform.position;
            selectedSlot = slots[0];
        } 
        if (Input.GetKeyDown(KeyCode.Alpha2)) { 
            selector.transform.position = slots[1].transform.position;
            selectedSlot = slots[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { 
            selector.transform.position = slots[2].transform.position;
            selectedSlot = slots[2];
        } 
        if (Input.GetKeyDown(KeyCode.Alpha4)) { 
            selector.transform.position = slots[3].transform.position;
            selectedSlot = slots[3];
        }
    }
}
