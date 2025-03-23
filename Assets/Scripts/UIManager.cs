using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private GameObject uiMainMenu;
    [SerializeField] private GameObject uiStatus;
    [SerializeField] private GameObject uiInventory;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void ShowMainMenu()
    {
        uiMainMenu.SetActive(true);
        uiStatus.SetActive(false);
        uiInventory.SetActive(false);
    }

    public void ShowStatus()
    {
        uiMainMenu.SetActive(false);
        uiStatus.SetActive(true);
        uiInventory.SetActive(false);
    }

    public void ShowInventory()
    {
        uiMainMenu.SetActive(false);
        uiStatus.SetActive(false);
        uiInventory.SetActive(true);
    }
}
