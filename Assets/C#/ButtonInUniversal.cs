using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInUniversal : MonoBehaviour
{
    // ยืนยันไปยังแมปดังกล่าว
    public void ConfirmSelectMap()
    {
        string map = SelectMapPage.selectMap;
        SceneManager.LoadScene(map);
    }

    // กลับไปหน้าเลือกแมป
    public void GoBackSelectMap()
    {
        SceneManager.LoadScene("Select Map");
    }

    // กลับไปหน้าล็อบบี๊
    public void GoBackLobby() {
        SceneManager.LoadScene("Lobby");
    }
}
