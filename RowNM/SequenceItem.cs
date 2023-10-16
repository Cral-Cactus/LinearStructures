using System;

namespace RowNM
{
    internal class SequenceItem
    {
        public int Value { get; set; }
        public SequenceItem Previous { get; set; }

        public SequenceItem(int value, SequenceItem previous)
        {
            Value = value;
            Previous = previous;
        }
    }
}