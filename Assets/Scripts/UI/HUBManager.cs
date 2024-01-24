using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUBManager : MonoBehaviour
{
    public static HUBManager instance { get; private set; }

    [Header("Menu References")]
    [SerializeField] private GameObject m_interactPrompt;
    [SerializeField] private GameObject m_actionPrompt;
    [SerializeField] private GameObject m_healthBar;
    [SerializeField] private RectTransform m_poisonBar;
    [SerializeField] private RectTransform m_poisonBarRate;
    [SerializeField] private GameObject m_pauseMenu;
    [SerializeField] private GameObject m_mainMenu;
    [SerializeField] private GameObject m_rechargePrompt;
    [SerializeField] private GameObject m_rechargingPrompt;
    [SerializeField] private GameObject m_noteDisplay;
    [SerializeField] private TextMeshProUGUI m_noteContent;

    [Header("Material References")]
    [SerializeField] private Material m_oclusionMaterial;

    [Header("Inhibitors")]
    [SerializeField] private GameObject m_inhibitors;
    [SerializeField] private GameObject m_inhibitorImage;
    [SerializeField] private GameObject m_noInhibitorImage;
    [SerializeField] private TextMeshProUGUI m_inhibitorNumbers;

    private float m_learpSpeed;
    private float m_poisonMaxWidth;

    private bool m_isInhibitorsFound; //if the player have picked up inhibitors for the first time

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;
    }

    private void Start()
    {
        m_interactPrompt.SetActive(false);
        m_pauseMenu.SetActive(false);
        m_rechargePrompt.SetActive(false);
        m_rechargingPrompt.SetActive(false);
        m_noteDisplay.SetActive(false);

        m_poisonMaxWidth = m_healthBar.GetComponent<RectTransform>().rect.width -10;
        m_poisonBar.sizeDelta = new Vector2(0f, m_poisonBar.rect.height);
        m_poisonBarRate.sizeDelta = new Vector2(0f, m_poisonBarRate.rect.height);
        m_noteContent = m_noteDisplay.GetComponentInChildren<TextMeshProUGUI>();

        m_isInhibitorsFound = false;
        HideInhibitors();
    }

    private void Update()
    {
        //HealthBar
        m_learpSpeed = 5f * Time.deltaTime;
        m_poisonBar.sizeDelta = new Vector2(Mathf.Clamp(Mathf.Lerp(m_poisonBar.rect.width, GameManager.instance.Poison / 100 * m_poisonMaxWidth, m_learpSpeed), 0f, m_poisonMaxWidth), m_poisonBar.rect.height);

        m_oclusionMaterial.SetFloat("_VignetteRadius", Mathf.Lerp(m_oclusionMaterial.GetFloat("_VignetteRadius"), 1 - (GameManager.instance.Poison/100), m_learpSpeed));

        //in case the poison its full poisonRate hides
        if (GameManager.instance.Poison == 100f)
            m_poisonBarRate.sizeDelta = new Vector2(Mathf.Lerp(m_poisonBarRate.rect.width, 0, m_learpSpeed), m_poisonBarRate.rect.height);
        else
        {
            //prevents the bar from coming out on the bar container
            if (m_poisonBarRate.rect.width < m_poisonBar.rect.width)
                m_poisonBarRate.sizeDelta = new Vector2(Mathf.Clamp(Mathf.Lerp(m_poisonBarRate.rect.width, GameManager.instance.PoisonRate * 1000, m_learpSpeed), 0f, m_poisonMaxWidth), m_poisonBarRate.rect.height);
            else
                m_poisonBarRate.sizeDelta = new Vector2(m_poisonBar.rect.width, m_poisonBarRate.rect.height);
        }
    }

    public void ResetHUB()
    {
        m_interactPrompt.SetActive(false);
        m_actionPrompt.SetActive(false);
        m_healthBar.SetActive(false);
        m_pauseMenu.SetActive(false);
        m_rechargePrompt.SetActive(false);
        m_rechargingPrompt.SetActive(false);
        m_noteDisplay.SetActive(false);

        m_poisonBar.sizeDelta = new Vector2(0f, m_poisonBar.rect.height);
        m_poisonBarRate.sizeDelta = new Vector2(0f, m_poisonBarRate.rect.height);
        m_poisonMaxWidth = m_healthBar.GetComponent<RectTransform>().rect.width - 10;
        m_oclusionMaterial.SetFloat("_VignetteRadius", 1);
    }

    public void UseActionPromp(Sprite sprite, string text, float time)
    {
        m_actionPrompt.GetComponent<UIActionPrompt>().UseActionPrompt(sprite, text, time);
    }

    public void InteractPromptActive(bool value, string prompt)
    {
        m_interactPrompt.SetActive(value);
        m_interactPrompt.GetComponentInChildren<TextMeshProUGUI>().text = prompt;
    }

    public void HealthBarActive(bool value)
    {
        m_healthBar.SetActive(value);
    }

    public void RechargePromptActive(bool value)
    {
        m_rechargePrompt.SetActive(value);
    }

    public void RechargingPromptActive(bool value)
    {
        m_rechargingPrompt.SetActive(value);
    }

    public void PauseMenuActive(bool value)
    {
        m_pauseMenu.SetActive(value);
    }

    public void MainMenuActive(bool value)
    {
        m_mainMenu.SetActive(value);
    }

    public void ShowNote(string noteContent)
    {
        m_noteDisplay.SetActive(true);
        m_noteContent.text = noteContent;
    }

    public void HideNote()
    {
        m_noteDisplay.SetActive(false);
    }

#region Inhibitors
    public void UpdateInhibitors()
    {
        //The inhibitors are hide before the payer found the first one
        if (!m_isInhibitorsFound)
        {
            m_isInhibitorsFound = true;
            ShowInhibitors();
        }

        if (GameManager.instance.Inhibitors <= 0) {
            m_inhibitorImage.SetActive(false);
            m_noInhibitorImage.SetActive(true);
        }
        else
        {
            m_inhibitorImage.SetActive(true);
            m_noInhibitorImage.SetActive(false);
        }

        m_inhibitorNumbers.text = GameManager.instance.Inhibitors.ToString();
    }

    public void ShowInhibitors()
    {
        m_inhibitors.SetActive(true);
    }

    public void HideInhibitors()
    {
        m_inhibitors.SetActive(false);
    }

    #endregion

}