using UnityEngine;

public class CarController : BaseController
{
    private readonly ResourcePath _viewPath = new ResourcePath { PathResource = "Prefabs/WinterYellowCar" };
    private readonly CarView _carView;

    public CarController()
    {
        _carView = LoadView();
    }

    private CarView LoadView()
    {
        var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath));
        AddGameObject(objectView);
        return objectView.GetComponent<CarView>();
    }

    public GameObject GetViewObject()
    {
        return _carView.gameObject;
    }
}
