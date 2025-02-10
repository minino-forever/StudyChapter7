using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    internal class Car
    {
        public const int MaXSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;

        public string PetName { get; set; } = "";

        private bool _carIsDead;

        private readonly Radio _theMusicBox = new Radio();

        public Car() { }

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            _theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine($"{PetName} is out of order...");
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaXSpeed)
                {
                    //Console.WriteLine($"{PetName} has overheated!");
                    CurrentSpeed = 0;

                    _carIsDead = true;

                    //создать и сконфигурировать новый экземпляр класса System.Exception
                    throw new Exception($"{PetName} has overheated!");
                    //}
                    //else
                    //{
                }
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
                
            }
        }

    }
}
