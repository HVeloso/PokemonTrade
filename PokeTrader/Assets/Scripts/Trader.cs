using TMPro;
using System;
using UnityEngine;
using System.Collections;

public class Trader : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _requerimentsText;
    [SerializeField] private GameObject _interactionIcon;
    [SerializeField] private PokemonStatus _pokemonStatus;
    [SerializeField] private Transform _player;

    private TradeSender _tradeSender;
    public static bool CanInteract = true;

    public static Action TradeSuccessful;
    public static Action TradeFailed;

    private void OnEnable()
    {
        TradeSuccessful += RunSuccessfulMessage;
        TradeFailed += RunFailMessage;
    }

    private void OnDisable()
    {
        TradeSuccessful -= RunSuccessfulMessage;
        TradeFailed -= RunFailMessage;
    }

    private void Awake()
    {
        SetTradeMessage();
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, _player.position) <= 2)
        {
            if (CanInteract)
            {
                _interactionIcon.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    CanInteract = false;
                    Debug.Log("Interacted");
                    _tradeSender = new(_pokemonStatus);
                    _tradeSender.RealizeTests();
                }
            }
            else
            {
                _interactionIcon.SetActive(false);
            }
        }
        else
        {
                _interactionIcon.SetActive(false);
        }
    }

    private void SetTradeMessage()
    {
        _requerimentsText.text = "";

        _requerimentsText.text += $"Eu quero um pokemon com pelo menos:\n";
        _requerimentsText.text += $" - 30 de ataque.\n";
        _requerimentsText.text += $" - 20 de HP.\n";
        _requerimentsText.text += $" - 15 de defesa.\n";
    }

    private void RunSuccessfulMessage()
    {
        StartCoroutine(PrintTradeResult("Isso mesmo. OBRIGADO!"));
    }

    private void RunFailMessage()
    {
        StartCoroutine(PrintTradeResult("NÃO! Esse pokemon não é bom o bastante."));
    }

    private IEnumerator PrintTradeResult(string message)
    {
        _requerimentsText.text = message;
        yield return new WaitForSeconds(1.5f);
        CanInteract = true;
        SetTradeMessage();
    }
}
