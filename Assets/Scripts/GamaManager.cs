using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Character Player { get; private set; }

    [SerializeField] private UIInventory uiInventory;
    [SerializeField] private Sprite[] itemIcons;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        InitPlayerData();
    }

    private void InitPlayerData()
    {
        Player = new Character("Chad", 10, 20000);

        // 아이템 테스트 추가
        for (int i = 0; i < 11 && i < itemIcons.Length; i++)
        {
            Player.AddItem(new Item($"Item {i + 1}", itemIcons[i]));
        }

        uiInventory.InitInventoryUI(Player.Inventory);
    }
}
