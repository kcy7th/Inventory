using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Transform slotParent;
    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private TextMeshProUGUI inventoryText;

    private List<UISlot> slotList = new List<UISlot>();

    public void InitInventoryUI(List<Item> items, int maxSlotCount = 120)
    {
        foreach (Transform child in slotParent)
            Destroy(child.gameObject);
        slotList.Clear();

        inventoryText.text = $"{items.Count} / {maxSlotCount}";

        foreach (var item in items)
        {
            var slot = Instantiate(slotPrefab, slotParent);
            slot.SetItem(item);
            slotList.Add(slot);
        }

        for (int i = 0; i < maxSlotCount - items.Count; i++)
        {
            var emptySlot = Instantiate(slotPrefab, slotParent);
            emptySlot.SetItem(null);
            slotList.Add(emptySlot);
        }
    }
}
