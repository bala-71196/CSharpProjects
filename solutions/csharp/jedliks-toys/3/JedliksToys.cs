class RemoteControlCar
{
    private int _battery = 100;
    private int _distanceDriven = 0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();
    
    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";

    public string BatteryDisplay()
    {
        if (_battery == 0)
        {
            return "Battery empty";  
        }
        else
        {
            return $"Battery at {_battery}%";
        }
    }

    public void Drive()
    {    
        if (_battery != 0)
        {
            _distanceDriven += 20;
            _battery -= 1; 
        }
        DistanceDisplay();
        BatteryDisplay();
    }
}
