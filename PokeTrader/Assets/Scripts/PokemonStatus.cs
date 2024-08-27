using UnityEngine;

public class PokemonStatus : MonoBehaviour
{
    private const int _minStatus = 10;
    private const int _maxStatus = 50;

    private int _attack;
    private int _hp;
    private int _deffence;

    public int Attack
    {
        get { return _attack; }
        set
        {
            _attack = Mathf.Clamp(value, _minStatus, _maxStatus);
        }
    }

    public int HP
    {
        get { return _hp; }
        set
        {
            _hp = Mathf.Clamp(value, _minStatus, _maxStatus);
        }
    }

    public int Deffence
    {
        get { return _deffence; }
        set
        {
            _deffence = Mathf.Clamp(value, _minStatus, _maxStatus);
        }
    }

    private void Awake()
    {
        RandomizeStatus();
    }

    private void Update()
    {
        if (Trader.CanInteract)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RandomizeStatus();
            }
        }
    }

    private void RandomizeStatus()
    {
        Attack = Random.Range(_minStatus, _maxStatus);
        HP = Random.Range(_minStatus, _maxStatus);
        Deffence = Random.Range(_minStatus, _maxStatus);
    }
}
