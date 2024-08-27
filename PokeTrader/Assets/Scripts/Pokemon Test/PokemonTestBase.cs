public abstract class PokemonTestBase
{
    protected PokemonTestBase _nextTest;

    public PokemonTestBase SetNextTest(PokemonTestBase nextTest)
    {
        _nextTest = nextTest;
        return nextTest;
    }

    public abstract bool TestStatus(PokemonStatus sender);
}
