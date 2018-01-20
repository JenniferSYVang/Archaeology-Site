using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEditor;

public class VoiceRecog : MonoBehaviour
{
    [SerializeField]
    private string[] m_Keywords;

    private KeywordRecognizer m_Recognizer;
    public GameObject player;
    public GameObject st1;
    public GameObject st4;
    public GameObject st6;

    void Start()
    {
        Debug.Log("VoiceRecog starting up");
        m_Keywords = new string[4];
        m_Keywords[0] = "Teleport test 1";
        m_Keywords[1] = "Teleport test 4";
        m_Keywords[2] = "Teleport test 6";
        m_Keywords[3] = "Quit Simulation";
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        m_Recognizer.Start();

    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("VoiceRecog OnPhraseRecognized");
        if (args.text == m_Keywords[0])
        {
            player.transform.position = st1.transform.position;
        }
        else if(args.text == m_Keywords[1])
        {
            player.transform.position = st4.transform.position;
        }
        else if(args.text == m_Keywords[2])
        {
            player.transform.position = st6.transform.position;
        }
        else if(args.text == m_Keywords[3])
        {
            EditorApplication.isPlaying = false;
        }
    }
}
