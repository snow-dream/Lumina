using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountSpeed", columnHash: 0x91ab8236 )]
    public class MountSpeed : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public uint Quest;

        // col: 01 offset: 0004
        public uint unknown4;

        // col: 02 offset: 0008
        public byte unknown8;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );


        }
    }
}