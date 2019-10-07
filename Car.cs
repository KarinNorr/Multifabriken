using System;

namespace Multifabriken
{
    class Car
    {
        string[] availableModels = new string[] {
            "Hatchback",
            "stationWagon",
            "cabriolet"
        };
        public string Color { get; set; }
        public string Model { get; set; }
        public bool Fancy { get; set; }

        public void SetModel(int index)
        {
            Model = availableModels[index];
        }
        public Car(string color, string model, bool fancy)
        {
            Color = color;
            Model = model;
            Fancy = fancy;
        }

        public string Content()
        {
            string str = "";
            str = "Typ: Car | Color: " + Color + " | Model: " + Model + " | Fancy: " + Fancy;
            return str;
        }

    }
}