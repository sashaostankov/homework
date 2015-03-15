//
// Ostankov Alexander
// Higher School of Economics
// sashaostankov@gmail.com
// (c) 2015
//

namespace DataIO
{
    public struct TrainData
    {
        public string Id;
        public string Type;
        public string Model;
        public string Create;
        public string Repair;

        public TrainData 
        (
            string id,
            string type,
            string model,
            string create,
            string repair
        )
        {
            Id = id;
            Type = type;
            Model = model;
            Create = create;
            Repair = repair;
        }

        public bool IsValidData()
        {
            return Train.IsValidTrainData(this);
        }
    }
}
