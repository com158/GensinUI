using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIManeger : MonoBehaviour
{
    [SerializeField] GameObject MenuCanvas;

    [SerializeField] GameObject TeamCompositionPanel;
    [SerializeField] GameObject FriendPanel;
    [SerializeField] GameObject AchievementPanel;
    [SerializeField] GameObject PicturebookPanel;
    [SerializeField] GameObject CharactorPictureBookPanel;
    [SerializeField] GameObject CharactorPanel;
    [SerializeField] GameObject BagPanel;
    [SerializeField] GameObject TaskPanel;
    [SerializeField] GameObject MapPanel;
    [SerializeField] GameObject EventPanel;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            MenuCanvas.SetActive(true);
            Canvas canvas = GameObject.Find("MenuCanvas").GetComponent<Canvas>();
            canvas.enabled = !canvas.enabled;

            TeamCompositionPanel.SetActive(false);
            FriendPanel.SetActive(false);
            AchievementPanel.SetActive(false);
            PicturebookPanel.SetActive(false);
            CharactorPictureBookPanel.SetActive(false);
            CharactorPanel.SetActive(false);
            BagPanel.SetActive(false);
            TaskPanel.SetActive(false);
            MapPanel.SetActive(false);
            EventPanel.SetActive(false);
        }
    }

    public void ClickTeamComposition()
    {
        Debug.Log(gameObject.name + "がクリックされた！");

        FriendPanel.SetActive(false);
        AchievementPanel.SetActive(false);
        PicturebookPanel.SetActive(false);
        CharactorPictureBookPanel.SetActive(false);
        CharactorPanel.SetActive(false);
        BagPanel.SetActive(false);
        TaskPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventPanel.SetActive(false);

        TeamCompositionPanel.SetActive(true);
    }

    public void ClickFriend()
    {
        TeamCompositionPanel.SetActive(false);
        AchievementPanel.SetActive(false);
        PicturebookPanel.SetActive(false);
        CharactorPictureBookPanel.SetActive(false);
        CharactorPanel.SetActive(false);
        BagPanel.SetActive(false);
        TaskPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventPanel.SetActive(false);

        FriendPanel.SetActive(true);
    }

    public void ClickAchievement()
    {
        TeamCompositionPanel.SetActive(false);
        FriendPanel.SetActive(false);
        PicturebookPanel.SetActive(false);
        CharactorPictureBookPanel.SetActive(false);
        CharactorPanel.SetActive(false);
        BagPanel.SetActive(false);
        TaskPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventPanel.SetActive(false);

        AchievementPanel.SetActive(true);
    }

    public void ClickPicturebook()
    {
        TeamCompositionPanel.SetActive(false);
        FriendPanel.SetActive(false);
        AchievementPanel.SetActive(false);
        CharactorPictureBookPanel.SetActive(false);
        CharactorPanel.SetActive(false);
        BagPanel.SetActive(false);
        TaskPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventPanel.SetActive(false);

        PicturebookPanel.SetActive(true);
    }

    public void ClickCharactorPictureBook()
    {
        TeamCompositionPanel.SetActive(false);
        FriendPanel.SetActive(false);
        AchievementPanel.SetActive(false);
        PicturebookPanel.SetActive(false);
        CharactorPanel.SetActive(true);
        BagPanel.SetActive(false);
        TaskPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventPanel.SetActive(false);

        CharactorPictureBookPanel.SetActive(true);
    }

    public void ClickCharactor()
    {
        TeamCompositionPanel.SetActive(false);
        FriendPanel.SetActive(false);
        AchievementPanel.SetActive(false);
        PicturebookPanel.SetActive(false);
        CharactorPictureBookPanel.SetActive(false);
        BagPanel.SetActive(false);
        TaskPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventPanel.SetActive(false);

        CharactorPanel.SetActive(true);
    }

    public void ClickBag()
    {
        TeamCompositionPanel.SetActive(false);
        FriendPanel.SetActive(false);
        AchievementPanel.SetActive(false);
        PicturebookPanel.SetActive(false);
        CharactorPictureBookPanel.SetActive(false);
        CharactorPanel.SetActive(false);
        TaskPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventPanel.SetActive(false);

        BagPanel.SetActive(true);
    }

    public void ClickTask()
    {
        TeamCompositionPanel.SetActive(false);
        FriendPanel.SetActive(false);
        AchievementPanel.SetActive(false);
        PicturebookPanel.SetActive(false);
        CharactorPictureBookPanel.SetActive(false);
        CharactorPanel.SetActive(false);
        BagPanel.SetActive(false);
        MapPanel.SetActive(false);
        EventPanel.SetActive(false);

        TaskPanel.SetActive(true);
    }

    public void ClickMap()
    {
        TeamCompositionPanel.SetActive(false);
        FriendPanel.SetActive(false);
        AchievementPanel.SetActive(false);
        PicturebookPanel.SetActive(false);
        CharactorPictureBookPanel.SetActive(false);
        CharactorPanel.SetActive(false);
        BagPanel.SetActive(false);
        TaskPanel.SetActive(false);
        EventPanel.SetActive(false);

        MapPanel.SetActive(true);
    }

    public void ClickEvent()
    {
        TeamCompositionPanel.SetActive(false);
        FriendPanel.SetActive(false);
        AchievementPanel.SetActive(false);
        PicturebookPanel.SetActive(false);
        CharactorPictureBookPanel.SetActive(false);
        CharactorPanel.SetActive(false);
        BagPanel.SetActive(false);
        MapPanel.SetActive(false);
        TaskPanel.SetActive(false);

        EventPanel.SetActive(true);
    }

    public void ClickExternalLink()
    {
        Application.OpenURL("https://genshin.mihoyo.com/ja/home");
    }

    public void ClickReport()
    {
        Application.OpenURL("https://genshin.mihoyo.com/ja/news/detail/5843");
    }
}
