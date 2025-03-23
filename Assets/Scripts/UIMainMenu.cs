using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    private void Start()
    {
        statusButton.onClick.AddListener(() =>
        {
            UIManager.Instance.ShowStatus();
        });

        inventoryButton.onClick.AddListener(() =>
        {
            UIManager.Instance.ShowInventory();
        });
    }
}
