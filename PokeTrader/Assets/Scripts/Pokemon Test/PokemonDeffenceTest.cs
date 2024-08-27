public class PokemonDeffenceTest : PokemonTestBase
{
    public override bool TestStatus(PokemonStatus sender)
    {
        if (sender.Deffence >= 15)
        {
            return _nextTest.TestStatus(sender);
        }
        else
        {
            return false;
        }
    }
}
