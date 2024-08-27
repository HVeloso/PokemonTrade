public class PokemonAttackTest : PokemonTestBase
{
    public override bool TestStatus(PokemonStatus sender)
    {
        if (sender.Attack >= 30)
        {
            return _nextTest.TestStatus(sender);
        }
        else
        {
            return false;
        }
    }
}
