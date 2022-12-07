using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CardController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    #region VARIABLES
    public Card cc_card;
    public Image cc_illustration, cc_img;
    public string cc_cardName, cc_cardType; 
    public string[] cc_cardSkills;
    public int cc_cardPoints; 
    public char cc_cardOperator;
    private Transform originalParent;
    #endregion

    private void Awake()
    {
        cc_img = GetComponent<Image>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    public void Initialize(Card _card)
    {
        this.cc_card = _card;
        cc_illustration.sprite = _card.illustration;
        cc_cardName = _card.cardName;
        cc_cardType = _card.cardType;
        cc_cardSkills = _card.cardSkills;
        cc_cardPoints = _card.cardPoints;
        cc_cardOperator = _card.cardOperator;
        originalParent = transform.parent;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.SetParent(transform.root);
        cc_img.raycastTarget = false;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        cc_img.raycastTarget = true;
        AnalyzePointerUp(eventData);
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    private void AnalyzePointerUp(PointerEventData _eventData)
    {
        //if (canCardBePlayed)
        //{

        //}
        transform.SetParent(originalParent);
        transform.localPosition = Vector3.zero;
        //Debug.Log(eventData.pointerEnter);
    }
}
