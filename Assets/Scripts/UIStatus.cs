using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button backButton;

    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI critText;

    private void Start()
    {
        backButton.onClick.AddListener(() => UIManager.Instance.OpenMainMenu());
    }

    public void RefreshUI(Character character)
    {
        attackText.text = character.GetTotalAttack().ToString();
        defenseText.text = character.GetTotalDefense().ToString();
        hpText.text = character.GetTotalHP().ToString();
        critText.text = character.GetTotalCrit().ToString();
    }
}