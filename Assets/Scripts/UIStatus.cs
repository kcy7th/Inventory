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
        attackText.text = character.GetTotalStat(StatType.Attack).ToString();
        defenseText.text = character.GetTotalStat(StatType.Defense).ToString();
        hpText.text = character.GetTotalStat(StatType.HP).ToString();
        critText.text = character.GetTotalStat(StatType.Crit).ToString();
    }
}