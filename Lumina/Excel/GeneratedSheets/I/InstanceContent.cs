using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContent", columnHash: 0xe8f48f92 )]
    public class InstanceContent : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 18:22:54 GMT


        // col: 17 offset: 0000
        public uint SortKey;

        // col: 18 offset: 0004
        public uint InstanceClearExp;

        // col: 21 offset: 0008
        public uint FinalBossCurrencyC;

        // col: 25 offset: 000c
        public uint NewPlayerBonusB;

        // col: 26 offset: 0010
        public uint[] unknown10;

        // col: 46 offset: 0024
        public uint unknown24;

        // col: 47 offset: 0028
        public uint InstanceClearGil;

        // col: 19 offset: 002c
        public ushort unknown2c;

        // col: 20 offset: 002e
        public ushort NewPlayerBonusA;

        // col: 22 offset: 0030
        public ushort unknown30;

        // col: 23 offset: 0032
        public ushort FinalBossCurrencyA;

        // col: 24 offset: 0034
        public ushort FinalBossCurrencyB;

        // col: 31 offset: 0038
        public ushort[] unknown38;

        // col: 36 offset: 0042
        public ushort[] unknown42;

        // col: 41 offset: 004c
        public ushort[] unknown4c;

        // col: 48 offset: 0054
        public byte InstanceContentRewardItem;

        // col: 06 offset: 0058
        public uint WinBGM;

        // col: 07 offset: 005c
        public uint Cutscene;

        // col: 11 offset: 0060
        public uint unknown60;

        // col: 12 offset: 0064
        public uint InstanceContentTextDataBossStart;

        // col: 13 offset: 0068
        public uint InstanceContentTextDataBossEnd;

        // col: 14 offset: 006c
        public uint BNpcBaseBoss;

        // col: 15 offset: 0070
        public uint InstanceContentTextDataObjectiveStart;

        // col: 49 offset: 0074
        public uint unknown74;

        // col: 51 offset: 0078
        public uint InstanceContentBuff;

        // col: 50 offset: 007c
        public int FinalBossExp;

        // col: 02 offset: 0080
        public ushort TimeLimitmin;

        // col: 04 offset: 0082
        public ushort unknown82;

        // col: 05 offset: 0084
        public ushort BGM;

        // col: 08 offset: 0086
        public ushort unknown86;

        // col: 16 offset: 0088
        public ushort InstanceContentTextDataObjectiveEnd;

        // col: 58 offset: 008a
        public ushort unknown8a;

        // col: 59 offset: 008c
        public ushort unknown8c;

        // col: 52 offset: 008e
        public short ReqInstance;

        // col: 00 offset: 0090
        public byte InstanceContentType;

        // col: 01 offset: 0091
        public byte WeekRestriction;

        // col: 09 offset: 0092
        public byte Order;

        // col: 53 offset: 0093
        public byte unknown93;

        // col: 54 offset: 0094
        public byte PartyCondition;

        // col: 55 offset: 0095
        public byte unknown95;

        // col: 56 offset: 0096
        public byte unknown96;

        // col: 03 offset: 0097
        private byte packed97;
        public bool packed97_1 => ( packed97 & 0x1 ) == 0x1;
        public bool Colosseum => ( packed97 & 0x2 ) == 0x2;
        public bool packed97_4 => ( packed97 & 0x4 ) == 0x4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 17 offset: 0000
            SortKey = parser.ReadOffset< uint >( 0x0 );

            // col: 18 offset: 0004
            InstanceClearExp = parser.ReadOffset< uint >( 0x4 );

            // col: 21 offset: 0008
            FinalBossCurrencyC = parser.ReadOffset< uint >( 0x8 );

            // col: 25 offset: 000c
            NewPlayerBonusB = parser.ReadOffset< uint >( 0xc );

            // col: 26 offset: 0010
            unknown10 = new uint[5];
            unknown10[0] = parser.ReadOffset< uint >( 0x10 );
            unknown10[1] = parser.ReadOffset< uint >( 0x14 );
            unknown10[2] = parser.ReadOffset< uint >( 0x18 );
            unknown10[3] = parser.ReadOffset< uint >( 0x1c );
            unknown10[4] = parser.ReadOffset< uint >( 0x36 );

            // col: 46 offset: 0024
            unknown24 = parser.ReadOffset< uint >( 0x24 );

            // col: 47 offset: 0028
            InstanceClearGil = parser.ReadOffset< uint >( 0x28 );

            // col: 19 offset: 002c
            unknown2c = parser.ReadOffset< ushort >( 0x2c );

            // col: 20 offset: 002e
            NewPlayerBonusA = parser.ReadOffset< ushort >( 0x2e );

            // col: 22 offset: 0030
            unknown30 = parser.ReadOffset< ushort >( 0x30 );

            // col: 23 offset: 0032
            FinalBossCurrencyA = parser.ReadOffset< ushort >( 0x32 );

            // col: 24 offset: 0034
            FinalBossCurrencyB = parser.ReadOffset< ushort >( 0x34 );

            // col: 31 offset: 0038
            unknown38 = new ushort[5];
            unknown38[0] = parser.ReadOffset< ushort >( 0x38 );
            unknown38[1] = parser.ReadOffset< ushort >( 0x3a );
            unknown38[2] = parser.ReadOffset< ushort >( 0x3c );
            unknown38[3] = parser.ReadOffset< ushort >( 0x3e );
            unknown38[4] = parser.ReadOffset< ushort >( 0x40 );

            // col: 36 offset: 0042
            unknown42 = new ushort[5];
            unknown42[0] = parser.ReadOffset< ushort >( 0x42 );
            unknown42[1] = parser.ReadOffset< ushort >( 0x44 );
            unknown42[2] = parser.ReadOffset< ushort >( 0x46 );
            unknown42[3] = parser.ReadOffset< ushort >( 0x48 );
            unknown42[4] = parser.ReadOffset< ushort >( 0x4a );

            // col: 41 offset: 004c
            unknown4c = new ushort[5];
            unknown4c[0] = parser.ReadOffset< ushort >( 0x4c );
            unknown4c[1] = parser.ReadOffset< ushort >( 0x4e );
            unknown4c[2] = parser.ReadOffset< ushort >( 0x50 );
            unknown4c[3] = parser.ReadOffset< ushort >( 0x52 );
            unknown4c[4] = parser.ReadOffset< ushort >( 0x20 );

            // col: 48 offset: 0054
            InstanceContentRewardItem = parser.ReadOffset< byte >( 0x54 );

            // col: 6 offset: 0058
            WinBGM = parser.ReadOffset< uint >( 0x58 );

            // col: 7 offset: 005c
            Cutscene = parser.ReadOffset< uint >( 0x5c );

            // col: 11 offset: 0060
            unknown60 = parser.ReadOffset< uint >( 0x60 );

            // col: 12 offset: 0064
            InstanceContentTextDataBossStart = parser.ReadOffset< uint >( 0x64 );

            // col: 13 offset: 0068
            InstanceContentTextDataBossEnd = parser.ReadOffset< uint >( 0x68 );

            // col: 14 offset: 006c
            BNpcBaseBoss = parser.ReadOffset< uint >( 0x6c );

            // col: 15 offset: 0070
            InstanceContentTextDataObjectiveStart = parser.ReadOffset< uint >( 0x70 );

            // col: 49 offset: 0074
            unknown74 = parser.ReadOffset< uint >( 0x74 );

            // col: 51 offset: 0078
            InstanceContentBuff = parser.ReadOffset< uint >( 0x78 );

            // col: 50 offset: 007c
            FinalBossExp = parser.ReadOffset< int >( 0x7c );

            // col: 2 offset: 0080
            TimeLimitmin = parser.ReadOffset< ushort >( 0x80 );

            // col: 4 offset: 0082
            unknown82 = parser.ReadOffset< ushort >( 0x82 );

            // col: 5 offset: 0084
            BGM = parser.ReadOffset< ushort >( 0x84 );

            // col: 8 offset: 0086
            unknown86 = parser.ReadOffset< ushort >( 0x86 );

            // col: 16 offset: 0088
            InstanceContentTextDataObjectiveEnd = parser.ReadOffset< ushort >( 0x88 );

            // col: 58 offset: 008a
            unknown8a = parser.ReadOffset< ushort >( 0x8a );

            // col: 59 offset: 008c
            unknown8c = parser.ReadOffset< ushort >( 0x8c );

            // col: 52 offset: 008e
            ReqInstance = parser.ReadOffset< short >( 0x8e );

            // col: 0 offset: 0090
            InstanceContentType = parser.ReadOffset< byte >( 0x90 );

            // col: 1 offset: 0091
            WeekRestriction = parser.ReadOffset< byte >( 0x91 );

            // col: 9 offset: 0092
            Order = parser.ReadOffset< byte >( 0x92 );

            // col: 53 offset: 0093
            unknown93 = parser.ReadOffset< byte >( 0x93 );

            // col: 54 offset: 0094
            PartyCondition = parser.ReadOffset< byte >( 0x94 );

            // col: 55 offset: 0095
            unknown95 = parser.ReadOffset< byte >( 0x95 );

            // col: 56 offset: 0096
            unknown96 = parser.ReadOffset< byte >( 0x96 );

            // col: 3 offset: 0097
            packed97 = parser.ReadOffset< byte >( 0x97, ExcelColumnDataType.UInt8 );


        }
    }
}