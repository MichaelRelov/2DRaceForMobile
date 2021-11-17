public class PlayerData
{
    public PlayerData()
    {
        Car = new Car(5.0f);
        State = new SubscriptionProperty<GameState>();
    }

    public SubscriptionProperty<GameState> State { get; private set; }
    public Car Car { get; private set; }
}