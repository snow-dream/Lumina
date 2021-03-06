using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompleteJournal", columnHash: 0x6f3a5c4a )]
    public class CompleteJournal : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 05 offset: 0000
        public string Name;

        // col: 00 offset: 0004
        public uint unknown4;

        // col: 04 offset: 0008
        public uint unknown8;

        // col: 03 offset: 000c
        public int Icon;

        // col: 06 offset: 0010
        public int[] Cutscene;

        // col: 01 offset: 0070
        public ushort RequiredLevel;

        // col: 02 offset: 0072
        public byte unknown72;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 5 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 4 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            Icon = parser.ReadOffset< int >( 0xc );

            // col: 6 offset: 0010
            Cutscene = new int[24];
            Cutscene[0] = parser.ReadOffset< int >( 0x10 );
            Cutscene[1] = parser.ReadOffset< int >( 0x14 );
            Cutscene[2] = parser.ReadOffset< int >( 0x18 );
            Cutscene[3] = parser.ReadOffset< int >( 0x1c );
            Cutscene[4] = parser.ReadOffset< int >( 0x20 );
            Cutscene[5] = parser.ReadOffset< int >( 0x24 );
            Cutscene[6] = parser.ReadOffset< int >( 0x28 );
            Cutscene[7] = parser.ReadOffset< int >( 0x2c );
            Cutscene[8] = parser.ReadOffset< int >( 0x30 );
            Cutscene[9] = parser.ReadOffset< int >( 0x34 );
            Cutscene[10] = parser.ReadOffset< int >( 0x38 );
            Cutscene[11] = parser.ReadOffset< int >( 0x3c );
            Cutscene[12] = parser.ReadOffset< int >( 0x40 );
            Cutscene[13] = parser.ReadOffset< int >( 0x44 );
            Cutscene[14] = parser.ReadOffset< int >( 0x48 );
            Cutscene[15] = parser.ReadOffset< int >( 0x4c );
            Cutscene[16] = parser.ReadOffset< int >( 0x50 );
            Cutscene[17] = parser.ReadOffset< int >( 0x54 );
            Cutscene[18] = parser.ReadOffset< int >( 0x58 );
            Cutscene[19] = parser.ReadOffset< int >( 0x5c );
            Cutscene[20] = parser.ReadOffset< int >( 0x60 );
            Cutscene[21] = parser.ReadOffset< int >( 0x64 );
            Cutscene[22] = parser.ReadOffset< int >( 0x68 );
            Cutscene[23] = parser.ReadOffset< int >( 0x6c );

            // col: 1 offset: 0070
            RequiredLevel = parser.ReadOffset< ushort >( 0x70 );

            // col: 2 offset: 0072
            unknown72 = parser.ReadOffset< byte >( 0x72 );


        }
    }
}