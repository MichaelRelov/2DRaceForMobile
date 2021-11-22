public class PlayerData
{
    public PlayerData(float speed, IAnalytics analytics)
    {
        Car = new Car(speed);
        State = new SubscriptionProperty<GameState>();
        Analytics = analytics;
    }

    public SubscriptionProperty<GameState> State { get; private set; }
    public Car Car { get; private set; }
    public IAnalytics Analytics { get; }
}