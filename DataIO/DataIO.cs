//
// Ostankov Alexander
// Higher School of Economics
// sashaostankov@gmail.com
// (c) 2015
//

using System;
using System.Collections;
using System.Collections.Generic;

namespace DataIO
{
    public class DataIO
    {
        public List<Train> Data { get; set; }

        // Локомотивы, ремонтировавшиеся более пяти лет назад
        public List<Train> OldRepairedTrains ()
        {
            var today = DateTime.Today;
            var fiveYearsAgo = new DateTime (today.Year - 5,
                                             today.Month,
                                             today.Day);

            // Compare() < 1 <=> Less or equal
            return Data.FindAll (x => (
                DateTime.Compare (x.Repair, fiveYearsAgo) < 1
            ));
        }

        // Годы, за которые построено больше всего локомотивов
        public List<Train> GetMostPopularYears ()
        {
            var res = new List<Train> ();
            var temp = new SortedSet<int>();
            var amount = new Dictionary<int, int> ();

            foreach (var train in Data)
            {
                int year = train.Create.Year;

                if (amount.ContainsKey (year))
                    amount[year]++;
                else
                    amount.Add (year, 1);
            }

            var arr = new List<Tuple<int, int>> ();

            foreach (var item in amount)
                arr.Add (new Tuple<int, int> (item.Value, item.Key));

            arr.Sort ();
            arr.Reverse ();

            for (int i = 0; i < Math.Min (arr.Count, 5); i++)
                temp.Add (arr[i].Item2);

            foreach (var item in this.Data)
                if (temp.Contains(item.Create.Year))
                    res.Add(item);

            return res;
        }

        // Наиболее представленные модели
        public List<Train> GetPopularModels ()
        {
            var res = new List<Train>();
            var temp = new SortedSet<string> ();
            var amount = new Dictionary<string, int> ();

            foreach (var train in Data)
            {
                if (amount.ContainsKey (train.Model))
                    amount[train.Model]++;
                else
                    amount.Add (train.Model, 1);
            }

            var arr = new List<Tuple<int, string>> ();

            foreach (var item in amount)
                arr.Add (new Tuple<int, string> (item.Value, item.Key));

            arr.Sort ();
            arr.Reverse ();

            for (int i = 0; i < Math.Min (arr.Count, 5); i++)
                temp.Add (arr[i].Item2);

            foreach (var item in this.Data)
                if (temp.Contains(item.Model))
                    res.Add(item);

            return res;
        }

        public List<TrainData> ToXmlFriendlyFormat()
        {
            var res = new List<TrainData>();

            foreach (var train in Data)
            {
                var item = new TrainData();

                item.Id = string.Format("{0}", train.Id);

                item.Type = train.Type;
                item.Model = train.Model;

                item.Create = train.Create.ToString("dd.MM.yyyy");
                item.Repair = train.Repair.ToString("dd.MM.yyyy");

                res.Add(item);
            }

            return res;
        }

        public void AddTrains(IEnumerable data)
        {
            foreach (var item in data)
                if (item is TrainData)
                if (Train.IsValidTrainData((TrainData)item))
                    Data.Add(new Train((TrainData)item));
        }

        public DataIO ()
        {
            Data = new List<Train> ();
        }

        public DataIO (IEnumerable data) : this ()
        {
            AddTrains(data);
        }
    }
}