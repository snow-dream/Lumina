using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StainTransient", columnHash: 0x5d58cc84 )]
    public class StainTransient : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public uint Item1;

        // col: 01 offset: 0004
        public uint Item2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item1 = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Item2 = parser.ReadOffset< uint >( 0x4 );


        }
    }
}