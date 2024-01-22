using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuGambarKiri, MenuGambarKanan, MenuGambarBawah, MenuButton, MenuInformasi, MenuPetunjuk;
    // Start is called before the first frame update
    void Start()
    {
        MenuGambarKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
    }
    public void MenuKembalibutton()
    {
        MenuGambarKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
    }
    public void MenuInformasiButton()
    {
        MenuGambarKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuGambarKanan.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
    }
    public void MenuPetunjukButton()
    {
        MenuGambarKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuGambarKanan.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuGambarBawah.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
