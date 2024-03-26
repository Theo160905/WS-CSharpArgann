using UnityEngine;

[CreateAssetMenu(fileName = "NewPlant", menuName = "Plants")]
public class SO_Plants : ScriptableObject
{
    public string Name;
    public int ID;
    public int MarketValue;
    public int SaleValue;
    public float GrowthTime;

    public int Nb_Plants;
}
