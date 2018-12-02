using System;
using System.Collections.Generic;

public class GasStation
{
    private int index;
    private int amountOfGas;
    private int distanceToNextStation;

    public GasStation(int index, int amountOfGas, int distanceToNextStation)
    {
        this.index = index;
        this.amountOfGas = amountOfGas;
        this.distanceToNextStation = distanceToNextStation;
    }

    public int Index
    {
        get { return index; }
    }

    public int AmountOfGas
    {
        get { return amountOfGas; }
    }

    public int DistanceToNextStation
    {
        get { return distanceToNextStation; }
    }
}

public class TruckTour
{
    static GasStation startStation = null;
    static Queue<GasStation> gasStations = new Queue<GasStation>();

    public static void Main()
    {
        var N = Convert.ToInt32(Console.ReadLine());
        for (int count = 0; count < N; count++)
        {
            var currentStation = Console.ReadLine().Split(' ');
            var amountOfGas = Convert.ToInt32(currentStation[0]);
            var distanceToNextStation = Convert.ToInt32(currentStation[1]);

            var newGasStation = new GasStation(count, amountOfGas, distanceToNextStation);
            gasStations.Enqueue(newGasStation);
        }
        StartTriping(gasStations.Dequeue());
    }

    static void StartTriping(GasStation currentGasStation)
    {
        gasStations.Enqueue(currentGasStation);
        startStation = currentGasStation;

        var quantityInTank = currentGasStation.AmountOfGas;

        while (quantityInTank >= currentGasStation.DistanceToNextStation)
        {
            quantityInTank -= currentGasStation.DistanceToNextStation;

            currentGasStation = gasStations.Dequeue();
            gasStations.Enqueue(currentGasStation);

            if (currentGasStation == startStation)
            {
                Console.WriteLine(startStation.Index);
                return;
            }

            quantityInTank += currentGasStation.AmountOfGas;
        }
        StartTriping(gasStations.Dequeue());
    }
}
