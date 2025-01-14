using DG.Tweening;
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
    [SerializeField] private GameObject m_pauseMenu;
    [SerializeField] private GameObject m_mainMenu;

    [Header("Health")]
    [SerializeField] private GameObject m_healthBar;
    [SerializeField] private RectTransform m_poisonBar;
    [SerializeField] private RectTransform m_poisonBarRate;
    private float m_healthLearpSpeed;
    private float m_poisonMaxWidth;

    [Header("Battery")]
    [SerializeField] private GameObject m_rechargePrompt;
    [SerializeField] private Image m_rechargingBar;
    [SerializeField] private Sprite m_rechargeKey;
    float m_batteryTimeElapsed;

    [Header("Pointer")]
    [SerializeField] private GameObject m_pointerPrompt;

    [Header("Material References")]
    [SerializeField] private Material m_oclusionMaterial;

    [Header("Inhibitors")]
    [SerializeField] private GameObject m_inhibitors;
    [SerializeField] private GameObject m_inhibitorImage;
    [SerializeField] private GameObject m_noInhibitorImage;
    [SerializeField] private TextMeshProUGUI m_inhibitorNumbers;
    private bool m_isInhibitorsFound; //if the player have picked up inhibitors for the first time
   
    [Space(15)]
    [SerializeField] private GameObject m_noteDisplay;

    [Space(15)]
    [SerializeField] private Texture2D m_cursor;

    [Space(15)]
    [SerializeField] private GameObject m_EndScrean;

    [HideInInspector]
    public bool isPauseMenuOpening; //or closing

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;

        m_poisonMaxWidth = m_healthBar.GetComponent<RectTransform>().rect.width - 10;

        Cursor.SetCursor(m_cursor, Vector2.zero, CursorMode.Auto);
    }

    private void Update()
    {
        //HealthBar
        m_healthLearpSpeed = 5f * Time.deltaTime;
        m_poisonBar.sizeDelta = new Vector2(Mathf.Clamp(Mathf.Lerp(m_poisonBar.rect.width, GameManager.instance.Poison / 100 * m_poisonMaxWidth, m_healthLearpSpeed), 0f, m_poisonMaxWidth), m_poisonBar.rect.height);

        if (GameManager.instance.IsDead)
            m_oclusionMaterial.SetFloat("_VignetteRadius", Mathf.Lerp(m_oclusionMaterial.GetFloat("_VignetteRadius"), -1.2f, Time.deltaTime*0.5f));
        else
            m_oclusionMaterial.SetFloat("_VignetteRadius", Mathf.Lerp(m_oclusionMaterial.GetFloat("_VignetteRadius"), 1 - (GameManager.instance.Poison / 100), m_healthLearpSpeed));
            

        //in case the poison its full poisonRate hides
        if (GameManager.instance.Poison == 100f)
            m_poisonBarRate.sizeDelta = new Vector2(Mathf.Lerp(m_poisonBarRate.rect.width, 0, m_healthLearpSpeed), m_poisonBarRate.rect.height);
        else
        {
            //prevents the bar from coming out on the bar container
            if (m_poisonBarRate.rect.width < m_poisonBar.rect.width)
                m_poisonBarRate.sizeDelta = new Vector2(Mathf.Clamp(Mathf.Lerp(m_poisonBarRate.rect.width, GameManager.instance.PoisonRate * 1000, m_healthLearpSpeed), 0f, m_poisonMaxWidth), m_poisonBarRate.rect.height);
            else
                m_poisonBarRate.sizeDelta = new Vector2(m_poisonBar.rect.width, m_poisonBarRate.rect.height);
        }

        //Battery charging bar
        if (GameManager.instance.IsCharging)
        {
            if (m_batteryTimeElapsed < GameManager.instance.ChargeBatteryDuration)
            {
                m_rechargingBar.fillAmount = Mathf.Lerp(0.0f, 1.0f, m_batteryTimeElapsed/GameManager.instance.ChargeBatteryDuration);
                m_batteryTimeElapsed += Time.deltaTime;
            }
        }
    }

    public void ResetHUB()
    {
        m_interactPrompt.SetActive(false);
        m_actionPrompt.SetActive(false);
        m_healthBar.SetActive(false);
        m_pauseMenu.SetActive(false);
        m_rechargePrompt.SetActive(false);
        m_rechargingBar.gameObject.SetActive(false);
        m_noteDisplay.SetActive(false);
        m_pointerPrompt.SetActive(true);
        m_EndScrean.SetActive(false);

        m_poisonBar.sizeDelta = new Vector2(0f, m_poisonBar.rect.height);
        m_poisonBarRate.sizeDelta = new Vector2(0f, m_poisonBarRate.rect.height);
        m_oclusionMaterial.SetFloat("_VignetteRadius", 1);
        HideInhibitors();
        m_isInhibitorsFound = false;

        m_poisonMaxWidth = m_healthBar.GetComponent<RectTransform>().rect.width - 10;

        if(!GameManager.instance.IsDead)
            m_oclusionMaterial.SetFloat("_VignetteRadius", 1);
    }


    public void UseActionPromp(Sprite sprite, string text, float time)
    {
        m_actionPrompt.GetComponent<UIActionPrompt>().UseActionPrompt(sprite, text, time);
    }

    public void InteractPromptActive(bool value, string prompt = "")
    {
        m_interactPrompt.SetActive(value);
        //m_interactPrompt.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = prompt;
        
        if (value)
            m_interactPrompt.transform.GetChild(1).GetComponent<ResizeTextConainer>().Initialize(prompt);
    }

    public void HealthBarActive(bool value)
    {
        if (!m_healthBar.activeSelf && value)
        {
            m_healthBar.GetComponent<Image>().fillAmount = 0;
            m_healthBar.GetComponent<Image>().DOFillAmount(1, 1f)
                .OnComplete( () => m_healthBar.SetActive(true));
        }

        m_healthBar.SetActive(value);

    }

    public void PauseMenuActive()
    {
        m_pauseMenu.SetActive(true);
        m_pauseMenu.GetComponent<UIPauseMenu>().OpenPauseMenu();
    }

    public void ResumeGame()
    {
        m_pauseMenu.GetComponent<UIPauseMenu>().Resume();
    }

    public void MainMenuActive()
    {
        m_mainMenu.SetActive(true);
        m_mainMenu.GetComponent<UIMainMenu>().OpenMenu();
    }

    public void PointerActive(bool value)
    {
        m_pointerPrompt.SetActive(value);
    }

#region Battery
    public void RechargePromptActive(bool value)
    {
        //m_rechargePrompt.SetActive(value);
        if(value)
            m_actionPrompt.GetComponent<UIActionPrompt>().UseActionPrompt(m_rechargeKey, "Need to Recharge", 10f);
    }

    public void RechargingPromptActive(bool value)
    {
        m_rechargingBar.gameObject.SetActive(value);
        m_rechargingBar.fillAmount = 0;
        m_batteryTimeElapsed = 0;
    }

#endregion

#region Note
    public void ShowNote(string noteContent)
    {
        m_noteDisplay.GetComponent<UINoteDisplay>().ShowNote(noteContent);
        InteractPromptActive(false);
    }

    public void  HideNote()
    {
        m_noteDisplay.GetComponent<UINoteDisplay>().HideNote();
    }

#endregion

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
        float xPosition = m_inhibitors.transform.position.x;
        m_inhibitors.transform.position = new Vector3(-200, m_inhibitors.transform.position.y, 0);

        m_inhibitors.SetActive(true);
        m_inhibitors.transform.DOMoveX(xPosition, 0.3f).SetEase(Ease.OutBack);

        HealthBarActive(true);
    }

    public void HideInhibitors()
    {
        m_inhibitors.SetActive(false);
    }

#endregion

    public void ShowEndSream()
    {
        m_EndScrean.SetActive(true);
    }
}
