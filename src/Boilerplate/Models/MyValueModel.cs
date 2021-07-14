namespace Models
{
    public readonly record struct MyRecordValueModel(int Number, nuint OtherNumber);

    public struct MyBasicValueModel
    {
        public int Number { get; set; }
        public nuint OtherNumber { get; set; }
    }
}
