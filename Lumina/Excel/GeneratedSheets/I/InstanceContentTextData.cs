using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContentTextData", columnHash: 0xdebb20e3 )]
    public class InstanceContentTextData : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string Text;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );


        }
    }
}