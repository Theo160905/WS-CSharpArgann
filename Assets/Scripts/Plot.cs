using UnityEngine;

public class Plot : MonoBehaviour
{
    public Plant Plant { get; private set; }

    public void PlantSeed(SO_Plants seedData)
    {
        if (Plant != null) return;

        GameObject obj = Instantiate(seedData.Prefab, transform.position, Quaternion.identity);
        Plant = obj.GetComponent<Plant>();
        Plant.Initialize(seedData);
        Plant.Growth();
    }

    public int GatherPlant()
    {
        if (Plant == null || !Plant.IsGrown) return 0;

        SO_Plants data = Plant.Data;
        Destroy(Plant.gameObject);
        Plant = null;
        return data.MarketValue;
    }
}
