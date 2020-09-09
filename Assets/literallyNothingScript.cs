using UnityEngine;
using System.Collections;
using System;

public class literallyNothingScript : MonoBehaviour
{
    public KMAudio Audio;


    void Awake()
    {
        Audio = GetComponent<KMAudio>();
    }

    protected bool Solve()
    {
        GetComponent<KMNeedyModule>().OnPass(); return false;
    }

    private readonly string TwitchHelpMessage = @"Use !{0} () to do literally nothing";

    IEnumerator ProcessTwitchCommand(string command)
    {
        string[] twitchArena = command.Trim().ToLowerInvariant().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (twitchArena.Length > 1 && (twitchArena[0] != "claim"))
        {
            if (twitchArena.Length > 1 && (twitchArena[0] != "literallyNothing"))
            {
                yield return null;
                //yield return "awardpoints -1";
            }
            else
            {
                Audio.PlaySoundAtTransform("easterEgg1", transform);
            }
        }
    }
}
