using UnityEngine;
using System.Collections;

public class LiterallyNothing : MonoBehaviour
{
    void Awake()
    {

    }

    protected bool Solve()
    {
        GetComponent<KMNeedyModule>().OnPass(); return false;
    }

    private readonly string TwitchHelpMessage = @"Use !{0} () to do literally nothing";

    IEnumerator ProcessTwitchCommand(string Command)
    {
        yield return null;
        yield return "awardpoints -1";
    }
}
