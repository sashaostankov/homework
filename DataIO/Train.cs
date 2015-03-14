//
// Ostankov Alexander
// Higher School of Economics
// sashaostankov@gmail.com
// (c) 2015
//

using System;
using System.Globalization;

namespace DataIO
{
    public class Train : IComparable<Train>
    {
        public int Id { get; protected set; }

        public string Type  { get; protected set; }
        public string Model { get; protected set; }

        public DateTime Create { get; protected set; }
        public DateTime Repair { get; protected set; }

        public Train ()
        {
            Type = string.Empty;
            Model = string.Empty;

            Create = new DateTime ();
            Repair = new DateTime ();
        }

        public Train (TrainData data)
        {
            if (!IsValidTrainData(data))
                throw new ArgumentException();

            Id = int.Parse(data.Id);

            Type = string.Copy (data.Type);
            Model = string.Copy (data.Model);

            Create = DateTime.ParseExact (data.Create, "dd.MM.yyyy", null);
            Repair = DateTime.ParseExact (data.Repair, "dd.MM.yyyy", null);
        }

        public override string ToString ()
        {
            return string.Format ("[Train: Id={0}, Type={1}, Model={2}, Create={3}, Repair={4}]",
                                  Id,
                                  Type,
                                  Model,
                                  Create,
                                  Repair);
        }

        public int CompareTo(Train other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public static bool IsValidTrainData ( TrainData data )
        {
            int id;
            DateTime result;

            if (!int.TryParse(data.Id, out id)) return false;
            if (string.IsNullOrEmpty(data.Type)) return false;
            if (string.IsNullOrEmpty(data.Model)) return false;

            if (!DateTime.TryParseExact(data.Create, "dd.MM.yyyy", null, 
                                        DateTimeStyles.None, out result)) return false;

            if (!DateTime.TryParseExact(data.Repair, "dd.MM.yyyy", null,
                                        DateTimeStyles.None, out result)) return false;

            return true;
        }
    }
}

