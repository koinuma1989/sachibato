using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCont : MonoBehaviour
{
    public Canvas startCanvas;
    public Canvas ruleDousurukaModal;
    public Canvas BattleCanvas;
    public Canvas ResultCanvas;

    int playNinzu;
    int kaitoMojisu;
    int kaitoJokenFlag;
    int syoriJokenFlag;
    string ngWord;

    private void Start()
    {
        startCanvas.SetActive(false);
        ruleDousurukaModal;
        BattleCanvas;
        ResultCanvas;
}

    public void HajimeruBtn() {
        startCanvas.enabled = false;
        ruleDousurukaModal
    }
}
