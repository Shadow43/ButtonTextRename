using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour
{
    public static SoundController Instance;
    public AudioSource Credits;
    public AudioSource LevelMusic;
    public AudioSource MainMenu;

    void Awake()
    {
        Instance = this;
    }



}
