using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager2 : MonoBehaviour
{
    public RectTransform MenuMenuButton, MenuStruktur, MenuKerak, MenuMantel, MenuLuar, MenuDalam;
    // Start is called before the first frame update
    void Start()
    {
        MenuMenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuStruktur.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuKerak.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuMantel.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLuar.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuDalam.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuKembalibutton()
    {
        MenuMenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuStruktur.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuKerak.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuMantel.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLuar.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuDalam.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuStrukturButton()
    {
        MenuMenuButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuStruktur.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKerak.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuMantel.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLuar.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuDalam.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuKerakButton()
    {
        MenuMenuButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuStruktur.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuKerak.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMantel.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLuar.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuDalam.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuMantelButton()
    {
        MenuMenuButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuStruktur.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuKerak.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuMantel.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLuar.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuDalam.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuLuarButton()
    {
        MenuMenuButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuStruktur.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuKerak.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuMantel.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLuar.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuDalam.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MenuDalamButton()
    {
        MenuMenuButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuStruktur.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuKerak.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuMantel.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLuar.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuDalam.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
