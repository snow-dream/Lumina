using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JobHudManual", columnHash: 0x21d1dec2 )]
    public class JobHudManual : IExcelRow
    {
        // column defs from Wed, 31 Jul 2019 22:24:05 GMT


        // col: 02 offset: 0000
        public uint Action;

        // col: 04 offset: 0004
        public uint unknown4;

        // col: 05 offset: 0008
        public ushort Guide;

        // col: 00 offset: 000a
        public byte unknowna;

        // col: 01 offset: 000b
        public byte unknownb;

        // col: 03 offset: 000c
        public byte unknownc;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Action = parser.ReadOffset< uint >( 0x0 );

            // col: 4 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 5 offset: 0008
            Guide = parser.ReadOffset< ushort >( 0x8 );

            // col: 0 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );

            // col: 1 offset: 000b
            unknownb = parser.ReadOffset< byte >( 0xb );

            // col: 3 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );


        }
    }
}