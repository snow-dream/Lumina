using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MateriaJoinRateGatherCraft", columnHash: 0xab31b42e )]
    public class MateriaJoinRateGatherCraft : IExcelRow
    {
        // column defs from Wed, 31 Jul 2019 22:24:05 GMT


        // col: 00 offset: 0000
        public float[] NQOvermeldPctSlot;

        // col: 04 offset: 0010
        public float[] HQOvermeldPctSlot;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            NQOvermeldPctSlot = new float[4];
            NQOvermeldPctSlot[0] = parser.ReadOffset< float >( 0x0 );
            NQOvermeldPctSlot[1] = parser.ReadOffset< float >( 0x4 );
            NQOvermeldPctSlot[2] = parser.ReadOffset< float >( 0x8 );
            NQOvermeldPctSlot[3] = parser.ReadOffset< float >( 0xc );

            // col: 4 offset: 0010
            HQOvermeldPctSlot = new float[4];
            HQOvermeldPctSlot[0] = parser.ReadOffset< float >( 0x10 );
            HQOvermeldPctSlot[1] = parser.ReadOffset< float >( 0x14 );
            HQOvermeldPctSlot[2] = parser.ReadOffset< float >( 0x18 );
            HQOvermeldPctSlot[3] = parser.ReadOffset< float >( 0x1c );


        }
    }
}