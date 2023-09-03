using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyPage : MonoBehaviour
{
    public void PlayButton() {
        SceneManager.LoadScene("Select Map");
    }

}
