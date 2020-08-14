using LINQtoCSV;

namespace Payment.Models
{
    public class TransactionRecords
    {
        [CsvColumn(FieldIndex = 1)]
        public long CreditCardNumber { get; set; }

        [CsvColumn(FieldIndex = 2)]
        public int CreditLimit { get; set; }

        [CsvColumn(FieldIndex = 3)]
        public int Count { get; set; }
    }
}
