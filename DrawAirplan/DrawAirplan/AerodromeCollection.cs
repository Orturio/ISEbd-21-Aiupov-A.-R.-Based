using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DrawAirplan
{
    class AerodromeCollection
    {
        readonly Dictionary<string, Aerodrome<Vehicle>> aerodromeStages;
        
        public List<string> Keys => aerodromeStages.Keys.ToList();
        
        private readonly int pictureWidth;
      
        private readonly int pictureHeight;

        private readonly char separator = ':';

        public AerodromeCollection(int pictureWidth, int pictureHeight)
        {
            aerodromeStages = new Dictionary<string, Aerodrome<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        
        public void AddAerodrome(string name)
        {
            if (aerodromeStages.ContainsKey(name))
            {
                return;
            }
            aerodromeStages.Add(name, new Aerodrome<Vehicle>(pictureWidth, pictureHeight));
        }
        
        public void DelAerodrome(string name)
        {
            if (aerodromeStages.ContainsKey(name))
            {
                aerodromeStages.Remove(name);
            }
        }
        
        public Aerodrome<Vehicle> this[string ind]
        {
            get
            {
                if (aerodromeStages.ContainsKey(ind))
                {
                    return aerodromeStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write($"AerodromeCollection{Environment.NewLine}", fs);
                    foreach (var level in aerodromeStages)
                    {
                        //Начинаем аэродром
                        writer.Write($"Aerodrome{separator}{level.Key}{Environment.NewLine}", fs);
                        foreach (ITransport aircraft in level.Value)
                        {
                            //Записываем тип мшаины
                            if (aircraft.GetType().Name == "Aircraft")
                            {
                                writer.Write($"Aircraft{separator}", fs);
                            }
                            if (aircraft.GetType().Name == "Airbus")
                            {
                                writer.Write($"Airbus{separator}", fs);
                            }
                            //Записываемые параметры
                            writer.Write(aircraft + Environment.NewLine, fs);
                        }
                    }
                }                
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("AerodromeCollection"))
                {
                    //очищаем записи
                    aerodromeStages.Clear();
                }

                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FormatException();
                }

                line = sr.ReadLine();
                Vehicle aircraft = null;
                string key = string.Empty;
                while (line != null && line.Contains("Aerodrome"))
                {
                    key = line.Split(separator)[1];
                    aerodromeStages.Add(key, new Aerodrome<Vehicle>(pictureWidth, pictureHeight));
                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Aircraft") || line.Contains("Airbus")))
                    {
                        if (line.Split(separator)[0] == "Aircraft")
                        {
                            aircraft = new Aircraft(line.Split(separator)[1]);
                        }

                        else if (line.Split(separator)[0] == "Airbus")
                        {
                            aircraft = new Airbus(line.Split(separator)[1]);
                        }

                        var result = aerodromeStages[key] + aircraft;
                        if (!result)
                        {
                            throw new NullReferenceException();
                        }

                        line = sr.ReadLine();
                    }
                }
            }
        }        
    }
}
