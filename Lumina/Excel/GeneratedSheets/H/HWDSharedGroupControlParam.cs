using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDSharedGroupControlParam", columnHash: 0xde74b4c4 )]
    public class HWDSharedGroupControlParam : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public byte unknown0;

        // col: 01 offset: 0001
        public byte ParamValue;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            ParamValue = parser.ReadOffset< byte >( 0x1 );


        }
    }
}