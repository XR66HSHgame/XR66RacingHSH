using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInUniversal : MonoBehaviour
{
    // �׹�ѹ��ѧ����ѧ�����
    public void ConfirmSelectMap()
    {
        string map = SelectMapPage.selectMap;
        SceneManager.LoadScene(map);
    }

    // ��Ѻ�˹�����͡���
    public void GoBackSelectMap()
    {
        SceneManager.LoadScene("Select Map");
    }

    // ��Ѻ�˹����ͺ���
    public void GoBackLobby() {
        SceneManager.LoadScene("Lobby");
    }
}
