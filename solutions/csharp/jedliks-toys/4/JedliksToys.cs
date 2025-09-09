class RemoteControlCar
{
    private const int BATTERY_DRAIN_RATE = 1;
    private const int DISTANCE_RATE = 20;
    
    private int _batteryPercentage = 100;
    private int _distanceDriven = 0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();
    
    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";

    public string BatteryDisplay() => IsBatteryEmpty ? "Battery empty" : $"Battery at {_batteryPercentage}%";

    public void Drive()
    {    
        if (IsBatteryEmpty) return;
        
        _distanceDriven += DISTANCE_RATE;
        _batteryPercentage -= BATTERY_DRAIN_RATE; 
    }

    private bool IsBatteryEmpty => _batteryPercentage == 0;
}
