class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[]{0,2,5,3,7,8,4};

    public int Today() => this.birdsPerDay[^1];

    public void IncrementTodaysCount()
    {
        int todaysCount = Today();
        this.birdsPerDay[^1] = todaysCount + 1;
    }

    public bool HasDayWithoutBirds() => Array.IndexOf(this.birdsPerDay,0) != -1;

    public int CountForFirstDays(int numberOfDays)
    {
        int countOfBirds = 0;

        for(int i = 0; i < numberOfDays; i++) {
            countOfBirds += this.birdsPerDay[i];
        }

        return countOfBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        foreach(int birdsVisitedCount in this.birdsPerDay) {
            if(birdsVisitedCount >= 5) busyDays++;
        }

        return busyDays;
    }
}
