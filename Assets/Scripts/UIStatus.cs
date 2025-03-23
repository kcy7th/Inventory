using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(() =>
        {
            UIManager.Instance.ShowMainMenu();
        });
    }
}
