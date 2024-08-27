public class PokemonHPTest : PokemonTestBase
{
    public override bool TestStatus(PokemonStatus sender)
    {
        if (sender.HP >= 20)
        {
            return _nextTest.TestStatus(sender);
        }
        else
        {
            return false;
        }
    }
}
