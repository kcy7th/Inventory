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
        Player = new Character("FriedPotato", 10, 20000);

        for (int i = 0; i < 11 && i < itemIcons.Length; i++)
        {
            StatType type = (StatType)(i % 4); 
            int amount = Random.Range(1, 10); 

            Player.AddItem(new Item($"Item {i + 1}", itemIcons[i], type, amount));
        }

        uiInventory.InitInventoryUI(Player.Inventory);
    }
}
