using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CycleTime", columnHash: 0x5d58cc84 )]
    public class CycleTime : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public uint FirstCycle;

        // col: 01 offset: 0004
        public uint Cycle;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            FirstCycle = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Cycle = parser.ReadOffset< uint >( 0x4 );


        }
    }
}