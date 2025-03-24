using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private GameObject uiStatus;
    [SerializeField] private GameObject uiInventory;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void OpenMainMenu()
    {
        uiStatus.SetActive(false);
        uiInventory.SetActive(false);
    }

    public void OpenStatus()
    {
        uiStatus.SetActive(true);
        uiInventory.SetActive(false);

        UIStatus statusUI = uiStatus.GetComponent<UIStatus>();
        statusUI.RefreshUI(GameManager.Instance.Player);
    }

    public void OpenInventory()
    {
        uiStatus.SetActive(false);
        uiInventory.SetActive(true);
    }
}
