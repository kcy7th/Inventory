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

    // 아이템 버튼 클릭 시 장착 / 해제
    public void OnClick()
    {
        if (currentItem == null) return;

        if (currentItem.IsEquipped)
            currentItem.UnEquip();

        else
            currentItem.Equip();

        RefreshUI();

        // UIStatus 검색해서 스탯 UI 갱신
        UIStatus statusUI = FindObjectOfType<UIStatus>();

        if (statusUI != null)
        {
            statusUI.RefreshUI(GameManager.Instance.Player);
        }
    }
}
