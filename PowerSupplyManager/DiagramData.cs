using System.Collections.Generic;
using System.Linq;

namespace PowerSupplyManager
{
    internal class DiagramData
    {
        public DiagramData(int blocksCount = 11)
        {
            _blocksCount = blocksCount;

            for (var i = 0; i < blocksCount; i++)
            {
                _data.Add(0);
            }
        }

        public DiagramDataItem[] Data
        {
            get
            {
                DiagramDataItem[] data;
                lock (_lockObj)
                {
                    data = _data.Select((x, i) => new DiagramDataItem
                                {
                                    Title = i * 10,
                                    Value = x
                                })
                                .ToArray();
                }

                return data;
            }
        }

        public void AddValue(float value)
        {
            List<float> data;

            lock (_lockObj)
            {
                data = new List<float>(_data);
            }

            while (data.Count >= _blocksCount)
            {
                data.RemoveAt(0);
            }

            data.Add(value);

            lock (_lockObj)
            {
                _data = data;
            }
        }

        private readonly object _lockObj = new object();
        private readonly int _blocksCount;
        private List<float> _data = new List<float>();
    }
}
