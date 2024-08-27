using UnityEngine;

public class TradeSender
{
    private PokemonStatus _status;

    public TradeSender(PokemonStatus status)
    {
        _status = status;
        Debug.Log("Created");
    }

    public void RealizeTests()
    {
        PokemonAttackTest attackTest = new PokemonAttackTest();
        PokemonHPTest hpTest = new PokemonHPTest();
        PokemonDeffenceTest deffenceTest = new PokemonDeffenceTest();
        PokemonConclusionTest conclusionTest = new PokemonConclusionTest();

        attackTest.SetNextTest(hpTest)
            .SetNextTest(deffenceTest)
            .SetNextTest(conclusionTest);

        bool test = attackTest.TestStatus(_status);

        if (test)
        {
            Trader.TradeSuccessful?.Invoke();
            Debug.Log("Successful");
        }
        else
        {
            Trader.TradeFailed?.Invoke();
            Debug.Log("Fail");
        }

    }
}
