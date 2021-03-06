using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnContent", columnHash: 0x5d58cc84 )]
    public class DawnContent : IExcelRow
    {
        // column defs from Mon, 15 Jul 2019 14:22:54 GMT


        // col: 00 offset: 0000
        public uint Content;

        // col: 01 offset: 0004
        public uint Exp;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Content = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Exp = parser.ReadOffset< uint >( 0x4 );


        }
    }
}