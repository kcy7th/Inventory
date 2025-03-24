using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private GameObject equipMark;

    private Item currentItem;

    public void SetItem(Item item)
    {
        currentItem = item;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (currentItem != null)
        {
            iconImage.sprite = currentItem.Icon;
            iconImage.enabled = true;
            equipMark.SetActive(currentItem.IsEquipped);
        }

        else
        {
            iconImage.enabled = false;
            equipMark.SetActive(false);
        }
    }

    public void OnClick()
    {
        if (currentItem == null) return;

        if (currentItem.IsEquipped)
            currentItem.UnEquip();

        else
            currentItem.Equip();

        RefreshUI();

        UIStatus statusUI = FindObjectOfType<UIStatus>();

        if (statusUI != null)
        {
            statusUI.RefreshUI(GameManager.Instance.Player);
        }
    }
}
