\ derived from TFT_8050A project by
\ Michael Damkier
\ Hamburg, Germany
\ (michael@vondervotteimittiss.com)


\   y offset from Y_DIGIT_LG
\ #define OFFSET_UNIT_LG 46
\   y offset from Y_DIGIT_SM
\ #define OFFSET_UNIT_SM 16

0  constant UNIT_NONE
1  constant UNIT_V
2  constant UNIT_mV
3  constant UNIT_microA
4  constant UNIT_mA
5  constant UNIT_Ohm
6  constant UNIT_kOhm
7  constant UNIT_MOhm
8  constant UNIT_dB
9  constant UNIT_mS
10 constant UNIT_nS
11 constant UNIT_Z

56 constant symbolUnit_x
41 constant symbolUnit_y
symbolUnit_x 7 + 8 / symbolUnit_y * constant symbolUnit_sz

create symbolUnit
  \   V
    $3C c, $03 c, $C0 c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $07 c, $80 c, $00 c, $00 c, $00 c, $00 c,
    $3E c, $07 c, $80 c, $00 c, $00 c, $00 c, $00 c,
    $1E c, $07 c, $80 c, $00 c, $00 c, $00 c, $00 c,
    $1E c, $07 c, $80 c, $00 c, $00 c, $00 c, $00 c,
    $1E c, $07 c, $80 c, $00 c, $00 c, $00 c, $00 c,
    $1E c, $07 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $1E c, $0F c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $0F c, $0F c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $0F c, $0F c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $0F c, $0F c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $0F c, $0E c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $0F c, $1E c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $0F c, $1E c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $07 c, $1E c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $07 c, $9E c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $07 c, $9C c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $07 c, $9C c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $07 c, $9C c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $03 c, $BC c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $03 c, $BC c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $03 c, $B8 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $03 c, $F8 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $03 c, $F8 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $01 c, $F8 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $01 c, $F8 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $01 c, $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $01 c, $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $01 c, $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $F0 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   mV
    $00 c, $00 c, $00 c, $3C c, $03 c, $C0 c, $00 c,
    $00 c, $00 c, $00 c, $3C c, $07 c, $80 c, $00 c,
    $00 c, $00 c, $00 c, $3E c, $07 c, $80 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $07 c, $80 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $07 c, $80 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $07 c, $80 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $07 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $0F c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $0F c, $0F c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $0F c, $0F c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $0F c, $0F c, $00 c, $00 c,
    $3C c, $F0 c, $F8 c, $0F c, $0E c, $00 c, $00 c,
    $3D c, $F9 c, $FC c, $0F c, $1E c, $00 c, $00 c,
    $3F c, $FF c, $FE c, $0F c, $1E c, $00 c, $00 c,
    $3F c, $FF c, $FE c, $07 c, $1E c, $00 c, $00 c,
    $3E c, $3F c, $3E c, $07 c, $9E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $07 c, $9C c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $07 c, $9C c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $07 c, $9C c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $03 c, $BC c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $03 c, $BC c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $03 c, $B8 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $03 c, $F8 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $03 c, $F8 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $01 c, $F8 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $01 c, $F8 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $01 c, $F0 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $01 c, $F0 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $01 c, $F0 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $F0 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $F0 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $F0 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   microA
    $00 c, $00 c, $00 c, $E0 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $F0 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $01 c, $F0 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $01 c, $F0 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $01 c, $F0 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $01 c, $F0 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $01 c, $F8 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $03 c, $B8 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $03 c, $B8 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $03 c, $B8 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $03 c, $BC c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $07 c, $BC c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $07 c, $BC c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $07 c, $BC c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $07 c, $9C c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $07 c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $0F c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $0F c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $0F c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $0F c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $0E c, $0F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1F c, $FF c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1F c, $FF c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $3F c, $FF c, $80 c, $00 c, $00 c,
    $3C c, $1E c, $3C c, $07 c, $80 c, $00 c, $00 c,
    $3E c, $1E c, $3C c, $07 c, $80 c, $00 c, $00 c,
    $3F c, $7C c, $3C c, $07 c, $80 c, $00 c, $00 c,
    $3F c, $FC c, $3C c, $07 c, $C0 c, $00 c, $00 c,
    $3F c, $FC c, $78 c, $03 c, $C0 c, $00 c, $00 c,
    $3F c, $F0 c, $78 c, $03 c, $C0 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   mA
    $00 c, $00 c, $00 c, $00 c, $E0 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $F0 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $01 c, $F0 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $01 c, $F0 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $01 c, $F0 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $01 c, $F0 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $01 c, $F8 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $03 c, $B8 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $03 c, $B8 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $03 c, $B8 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $03 c, $BC c, $00 c, $00 c,
    $3C c, $F0 c, $F8 c, $07 c, $BC c, $00 c, $00 c,
    $3D c, $F9 c, $FC c, $07 c, $BC c, $00 c, $00 c,
    $3F c, $FF c, $FE c, $07 c, $BC c, $00 c, $00 c,
    $3F c, $FF c, $FE c, $07 c, $9C c, $00 c, $00 c,
    $3E c, $3F c, $3E c, $07 c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0E c, $0F c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $1E c, $0F c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $1E c, $0F c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $1F c, $FF c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $1F c, $FF c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $3F c, $FF c, $80 c, $00 c,
    $3C c, $1E c, $1E c, $3C c, $07 c, $80 c, $00 c,
    $3C c, $1E c, $1E c, $3C c, $07 c, $80 c, $00 c,
    $3C c, $1E c, $1E c, $3C c, $07 c, $80 c, $00 c,
    $3C c, $1E c, $1E c, $3C c, $07 c, $C0 c, $00 c,
    $3C c, $1E c, $1E c, $78 c, $03 c, $C0 c, $00 c,
    $3C c, $1E c, $1E c, $78 c, $03 c, $C0 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   Ohm
    $00 c, $1F c, $F8 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $7F c, $FE c, $00 c, $00 c, $00 c, $00 c,
    $01 c, $FF c, $FF c, $80 c, $00 c, $00 c, $00 c,
    $03 c, $FE c, $7F c, $C0 c, $00 c, $00 c, $00 c,
    $07 c, $E0 c, $0F c, $E0 c, $00 c, $00 c, $00 c,
    $0F c, $C0 c, $03 c, $E0 c, $00 c, $00 c, $00 c,
    $1F c, $80 c, $01 c, $F0 c, $00 c, $00 c, $00 c,
    $1F c, $00 c, $01 c, $F8 c, $00 c, $00 c, $00 c,
    $3E c, $00 c, $00 c, $F8 c, $00 c, $00 c, $00 c,
    $3E c, $00 c, $00 c, $7C c, $00 c, $00 c, $00 c,
    $3E c, $00 c, $00 c, $7C c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $7C c, $00 c, $00 c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $7C c, $00 c, $00 c, $00 c,
    $3E c, $00 c, $00 c, $78 c, $00 c, $00 c, $00 c,
    $1E c, $00 c, $00 c, $78 c, $00 c, $00 c, $00 c,
    $1F c, $00 c, $00 c, $F0 c, $00 c, $00 c, $00 c,
    $0F c, $00 c, $00 c, $F0 c, $00 c, $00 c, $00 c,
    $07 c, $80 c, $01 c, $E0 c, $00 c, $00 c, $00 c,
    $03 c, $C0 c, $03 c, $C0 c, $00 c, $00 c, $00 c,
    $01 c, $E0 c, $07 c, $80 c, $00 c, $00 c, $00 c,
    $00 c, $F0 c, $1E c, $00 c, $00 c, $00 c, $00 c,
    $7F c, $FC c, $3F c, $FC c, $00 c, $00 c, $00 c,
    $7F c, $FC c, $3F c, $FC c, $00 c, $00 c, $00 c,
    $7F c, $FC c, $3F c, $FC c, $00 c, $00 c, $00 c,
    $7F c, $FC c, $3F c, $FC c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   kOhm
    $3C c, $00 c, $00 c, $1F c, $F8 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $7F c, $FE c, $00 c, $00 c,
    $3C c, $00 c, $01 c, $FF c, $FF c, $80 c, $00 c,
    $3C c, $00 c, $03 c, $FE c, $7F c, $C0 c, $00 c,
    $3C c, $00 c, $07 c, $E0 c, $0F c, $E0 c, $00 c,
    $3C c, $00 c, $0F c, $C0 c, $03 c, $E0 c, $00 c,
    $3C c, $00 c, $1F c, $80 c, $01 c, $F0 c, $00 c,
    $3C c, $00 c, $1F c, $00 c, $01 c, $F8 c, $00 c,
    $3C c, $00 c, $3E c, $00 c, $00 c, $F8 c, $00 c,
    $3C c, $00 c, $3E c, $00 c, $00 c, $7C c, $00 c,
    $3C c, $00 c, $3E c, $00 c, $00 c, $7C c, $00 c,
    $3C c, $1E c, $3C c, $00 c, $00 c, $7C c, $00 c,
    $3C c, $3E c, $7C c, $00 c, $00 c, $3C c, $00 c,
    $3C c, $3C c, $7C c, $00 c, $00 c, $3C c, $00 c,
    $3C c, $78 c, $7C c, $00 c, $00 c, $3C c, $00 c,
    $3C c, $78 c, $7C c, $00 c, $00 c, $3C c, $00 c,
    $3C c, $F0 c, $7C c, $00 c, $00 c, $3C c, $00 c,
    $3C c, $F0 c, $3C c, $00 c, $00 c, $3C c, $00 c,
    $3D c, $E0 c, $3C c, $00 c, $00 c, $3C c, $00 c,
    $3D c, $C0 c, $3C c, $00 c, $00 c, $7C c, $00 c,
    $3F c, $C0 c, $3E c, $00 c, $00 c, $78 c, $00 c,
    $3D c, $E0 c, $1E c, $00 c, $00 c, $78 c, $00 c,
    $3D c, $E0 c, $1F c, $00 c, $00 c, $F0 c, $00 c,
    $3D c, $F0 c, $0F c, $00 c, $00 c, $F0 c, $00 c,
    $3C c, $F0 c, $07 c, $80 c, $01 c, $E0 c, $00 c,
    $3C c, $F8 c, $03 c, $C0 c, $03 c, $C0 c, $00 c,
    $3C c, $78 c, $01 c, $E0 c, $07 c, $80 c, $00 c,
    $3C c, $7C c, $00 c, $F0 c, $1E c, $00 c, $00 c,
    $3C c, $3C c, $7F c, $FC c, $3F c, $FC c, $00 c,
    $3C c, $3E c, $7F c, $FC c, $3F c, $FC c, $00 c,
    $3C c, $1E c, $7F c, $FC c, $3F c, $FC c, $00 c,
    $3C c, $1F c, $7F c, $FC c, $3F c, $FC c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   MOhm
    $0F c, $00 c, $F0 c, $00 c, $1F c, $F8 c, $00 c,
    $0F c, $00 c, $F0 c, $00 c, $7F c, $FE c, $00 c,
    $0F c, $00 c, $F0 c, $01 c, $FF c, $FF c, $80 c,
    $0F c, $00 c, $F0 c, $03 c, $FE c, $7F c, $C0 c,
    $0F c, $80 c, $F0 c, $07 c, $E0 c, $0F c, $E0 c,
    $0F c, $81 c, $F8 c, $0F c, $C0 c, $03 c, $E0 c,
    $1F c, $81 c, $F8 c, $1F c, $80 c, $01 c, $F0 c,
    $1F c, $81 c, $F8 c, $1F c, $00 c, $01 c, $F8 c,
    $1F c, $81 c, $F8 c, $3E c, $00 c, $00 c, $F8 c,
    $1F c, $C1 c, $F8 c, $3E c, $00 c, $00 c, $7C c,
    $1F c, $C3 c, $F8 c, $3E c, $00 c, $00 c, $7C c,
    $1F c, $C3 c, $B8 c, $3C c, $00 c, $00 c, $7C c,
    $1D c, $C3 c, $B8 c, $7C c, $00 c, $00 c, $3C c,
    $1D c, $C3 c, $B8 c, $7C c, $00 c, $00 c, $3C c,
    $1D c, $E7 c, $B8 c, $7C c, $00 c, $00 c, $3C c,
    $1D c, $E7 c, $BC c, $7C c, $00 c, $00 c, $3C c,
    $1C c, $E7 c, $BC c, $7C c, $00 c, $00 c, $3C c,
    $1C c, $E7 c, $3C c, $3C c, $00 c, $00 c, $3C c,
    $3C c, $E7 c, $3C c, $3C c, $00 c, $00 c, $3C c,
    $3C c, $F7 c, $3C c, $3C c, $00 c, $00 c, $7C c,
    $3C c, $FF c, $3C c, $3E c, $00 c, $00 c, $78 c,
    $3C c, $7F c, $3C c, $1E c, $00 c, $00 c, $78 c,
    $3C c, $7E c, $3C c, $1F c, $00 c, $00 c, $F0 c,
    $3C c, $7E c, $3C c, $0F c, $00 c, $00 c, $F0 c,
    $3C c, $7E c, $3E c, $07 c, $80 c, $01 c, $E0 c,
    $3C c, $7E c, $3E c, $03 c, $C0 c, $03 c, $C0 c,
    $38 c, $3E c, $3E c, $01 c, $E0 c, $07 c, $80 c,
    $38 c, $3C c, $3E c, $00 c, $F0 c, $1E c, $00 c,
    $38 c, $3C c, $1E c, $7F c, $FC c, $3F c, $FC c,
    $38 c, $3C c, $1E c, $7F c, $FC c, $3F c, $FC c,
    $78 c, $3C c, $1E c, $7F c, $FC c, $3F c, $FC c,
    $78 c, $1C c, $1E c, $7F c, $FC c, $3F c, $FC c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   dB
    $00 c, $1E c, $1F c, $F0 c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1F c, $FC c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1F c, $FE c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1F c, $FE c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1E c, $3E c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1E c, $1F c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $00 c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $07 c, $9E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $0F c, $DE c, $1E c, $1E c, $00 c, $00 c, $00 c,
    $1F c, $FE c, $1E c, $1E c, $00 c, $00 c, $00 c,
    $1E c, $3E c, $1E c, $FC c, $00 c, $00 c, $00 c,
    $1E c, $3E c, $1F c, $F8 c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1F c, $FC c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1F c, $FE c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $3F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $1F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $0F c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $1F c, $00 c, $00 c, $00 c,
    $1E c, $3E c, $1E c, $1E c, $00 c, $00 c, $00 c,
    $1E c, $7E c, $1F c, $FE c, $00 c, $00 c, $00 c,
    $1F c, $FE c, $1F c, $FC c, $00 c, $00 c, $00 c,
    $0F c, $DE c, $1F c, $F8 c, $00 c, $00 c, $00 c,
    $07 c, $9E c, $1F c, $F0 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   mS
    $00 c, $00 c, $00 c, $01 c, $F8 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $07 c, $FC c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $07 c, $FC c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $0F c, $FC c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $0F c, $84 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $1F c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $F0 c, $F8 c, $0F c, $00 c, $00 c, $00 c,
    $3D c, $F9 c, $FC c, $0F c, $80 c, $00 c, $00 c,
    $3F c, $FF c, $FE c, $07 c, $C0 c, $00 c, $00 c,
    $3F c, $FF c, $FE c, $07 c, $E0 c, $00 c, $00 c,
    $3E c, $3F c, $3E c, $03 c, $E0 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $01 c, $F0 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $F8 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $7C c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $3C c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $3E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $00 c, $1E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $10 c, $3E c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $18 c, $7C c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $1F c, $FC c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $1F c, $F8 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $1F c, $F0 c, $00 c, $00 c,
    $3C c, $1E c, $1E c, $07 c, $E0 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   nS
    $00 c, $00 c, $01 c, $F8 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $07 c, $FC c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $07 c, $FC c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $0F c, $FC c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $0F c, $84 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $1F c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $1E c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $1E c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $1E c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $1E c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $1E c, $00 c, $00 c, $00 c, $00 c,
    $3C c, $F8 c, $0F c, $00 c, $00 c, $00 c, $00 c,
    $3D c, $FC c, $0F c, $80 c, $00 c, $00 c, $00 c,
    $3F c, $FE c, $07 c, $C0 c, $00 c, $00 c, $00 c,
    $3F c, $FE c, $07 c, $E0 c, $00 c, $00 c, $00 c,
    $3E c, $3E c, $03 c, $E0 c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $01 c, $F0 c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $00 c, $F8 c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $00 c, $7C c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $00 c, $3E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $00 c, $1E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $10 c, $3E c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $18 c, $7C c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1F c, $FC c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1F c, $F8 c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $1F c, $F0 c, $00 c, $00 c, $00 c,
    $3C c, $1E c, $07 c, $E0 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,

  \   Z
    $00 c, $1F c, $F8 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $7F c, $FE c, $00 c, $00 c, $00 c, $00 c,
    $01 c, $FF c, $FF c, $80 c, $00 c, $00 c, $00 c,
    $03 c, $FE c, $7F c, $C0 c, $00 c, $00 c, $00 c,
    $07 c, $E0 c, $0F c, $E0 c, $00 c, $00 c, $00 c,
    $0F c, $C0 c, $03 c, $E0 c, $00 c, $00 c, $00 c,
    $1F c, $80 c, $01 c, $F0 c, $00 c, $00 c, $00 c,
    $1F c, $00 c, $01 c, $F8 c, $00 c, $00 c, $00 c,
    $3E c, $00 c, $00 c, $F8 c, $00 c, $00 c, $00 c,
    $3E c, $00 c, $00 c, $7C c, $00 c, $00 c, $00 c,
    $3E c, $00 c, $00 c, $7C c, $00 c, $00 c, $00 c,
    $3C c, $00 c, $00 c, $7C c, $00 c, $00 c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $00 c, $00 c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $7F c, $FC c, $00 c,
    $7C c, $00 c, $00 c, $3C c, $7F c, $FC c, $00 c,
    $3C c, $00 c, $00 c, $3C c, $7F c, $FC c, $00 c,
    $3C c, $00 c, $00 c, $3C c, $00 c, $38 c, $00 c,
    $3C c, $00 c, $00 c, $7C c, $00 c, $38 c, $00 c,
    $3E c, $00 c, $00 c, $78 c, $00 c, $70 c, $00 c,
    $1E c, $00 c, $00 c, $78 c, $00 c, $70 c, $00 c,
    $1F c, $00 c, $00 c, $F0 c, $00 c, $E0 c, $00 c,
    $0F c, $00 c, $00 c, $F0 c, $00 c, $E0 c, $00 c,
    $07 c, $80 c, $01 c, $E0 c, $01 c, $C0 c, $00 c,
    $03 c, $C0 c, $03 c, $C0 c, $01 c, $C0 c, $00 c,
    $01 c, $E0 c, $07 c, $80 c, $03 c, $80 c, $00 c,
    $00 c, $F0 c, $1E c, $00 c, $03 c, $80 c, $00 c,
    $7F c, $FC c, $3F c, $FC c, $07 c, $00 c, $00 c,
    $7F c, $FC c, $3F c, $FC c, $07 c, $00 c, $00 c,
    $7F c, $FC c, $3F c, $FC c, $0E c, $00 c, $00 c,
    $7F c, $FC c, $3F c, $FC c, $0E c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $1C c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $1C c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $38 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $38 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $7F c, $FC c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $7F c, $FC c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $7F c, $FC c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c, $00 c, $00 c, $00 c, $00 c,


24 constant symbolUnitSmall_x
21 constant symbolUnitSmall_y
symbolUnitSmall_x 7 + 8 / symbolUnitSmall_y * constant symbolUnitSmall_sz

create symbolUnitSmall
  \   V
    $00 c, $00 c, $00 c,
    $C1 c, $80 c, $00 c,
    $C1 c, $80 c, $00 c,
    $C1 c, $80 c, $00 c,
    $C1 c, $80 c, $00 c,
    $E3 c, $80 c, $00 c,
    $63 c, $00 c, $00 c,
    $63 c, $00 c, $00 c,
    $63 c, $00 c, $00 c,
    $63 c, $00 c, $00 c,
    $63 c, $00 c, $00 c,
    $36 c, $00 c, $00 c,
    $36 c, $00 c, $00 c,
    $3E c, $00 c, $00 c,
    $1C c, $00 c, $00 c,
    $1C c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

  \   mV
    $00 c, $00 c, $00 c,
    $00 c, $0C c, $18 c,
    $00 c, $0C c, $18 c,
    $00 c, $0C c, $18 c,
    $00 c, $0C c, $18 c,
    $00 c, $0E c, $38 c,
    $00 c, $06 c, $30 c,
    $00 c, $06 c, $30 c,
    $DD c, $C6 c, $30 c,
    $EE c, $C6 c, $30 c,
    $CC c, $C6 c, $30 c,
    $CC c, $C3 c, $60 c,
    $CC c, $C3 c, $60 c,
    $CC c, $C3 c, $E0 c,
    $CC c, $C1 c, $C0 c,
    $CC c, $C1 c, $C0 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

  \   microA
    $00 c, $00 c, $00 c,
    $00 c, $1C c, $00 c,
    $00 c, $1C c, $00 c,
    $00 c, $3E c, $00 c,
    $00 c, $36 c, $00 c,
    $00 c, $36 c, $00 c,
    $00 c, $63 c, $00 c,
    $00 c, $63 c, $00 c,
    $CC c, $63 c, $00 c,
    $CC c, $63 c, $00 c,
    $CC c, $7F c, $00 c,
    $CC c, $FF c, $80 c,
    $CC c, $C1 c, $80 c,
    $CC c, $C1 c, $80 c,
    $FC c, $C1 c, $80 c,
    $F8 c, $C1 c, $80 c,
    $C0 c, $00 c, $00 c,
    $C0 c, $00 c, $00 c,
    $C0 c, $00 c, $00 c,
    $C0 c, $00 c, $00 c,
    $C0 c, $00 c, $00 c,

\   mA
    $00 c, $00 c, $00 c,
    $00 c, $01 c, $C0 c,
    $00 c, $01 c, $C0 c,
    $00 c, $03 c, $E0 c,
    $00 c, $03 c, $60 c,
    $00 c, $03 c, $60 c,
    $00 c, $06 c, $30 c,
    $00 c, $06 c, $30 c,
    $DD c, $C6 c, $30 c,
    $EE c, $C6 c, $30 c,
    $CC c, $C7 c, $F0 c,
    $CC c, $CF c, $F8 c,
    $CC c, $CC c, $18 c,
    $CC c, $CC c, $18 c,
    $CC c, $CC c, $18 c,
    $CC c, $CC c, $18 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

\   Ohm
    $00 c, $00 c, $00 c,
    $1F c, $80 c, $00 c,
    $3F c, $C0 c, $00 c,
    $70 c, $E0 c, $00 c,
    $E0 c, $70 c, $00 c,
    $C0 c, $30 c, $00 c,
    $C0 c, $30 c, $00 c,
    $C0 c, $30 c, $00 c,
    $C0 c, $30 c, $00 c,
    $C0 c, $30 c, $00 c,
    $C0 c, $30 c, $00 c,
    $60 c, $60 c, $00 c,
    $30 c, $C0 c, $00 c,
    $10 c, $80 c, $00 c,
    $F0 c, $F0 c, $00 c,
    $F0 c, $F0 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

\   kOhm
    $00 c, $00 c, $00 c,
    $C0 c, $1F c, $80 c,
    $C0 c, $3F c, $C0 c,
    $C0 c, $70 c, $E0 c,
    $C0 c, $E0 c, $70 c,
    $C0 c, $C0 c, $30 c,
    $C0 c, $C0 c, $30 c,
    $C0 c, $C0 c, $30 c,
    $CC c, $C0 c, $30 c,
    $CC c, $C0 c, $30 c,
    $D8 c, $C0 c, $30 c,
    $F0 c, $60 c, $60 c,
    $D8 c, $30 c, $C0 c,
    $CC c, $10 c, $80 c,
    $CC c, $F0 c, $F0 c,
    $CC c, $F0 c, $F0 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

\   MOhm
    $00 c, $00 c, $00 c,
    $61 c, $81 c, $F8 c,
    $61 c, $83 c, $FC c,
    $61 c, $87 c, $0E c,
    $61 c, $8E c, $07 c,
    $73 c, $8C c, $03 c,
    $73 c, $8C c, $03 c,
    $F3 c, $CC c, $03 c,
    $D2 c, $CC c, $03 c,
    $DE c, $CC c, $03 c,
    $DE c, $CC c, $03 c,
    $CC c, $C6 c, $06 c,
    $CC c, $C3 c, $0C c,
    $CC c, $C1 c, $08 c,
    $CC c, $CF c, $0F c,
    $CC c, $CF c, $0F c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

  \   dB
    $06 c, $00 c, $00 c,
    $06 c, $7C c, $00 c,
    $06 c, $7E c, $00 c,
    $06 c, $67 c, $00 c,
    $06 c, $63 c, $00 c,
    $06 c, $63 c, $00 c,
    $36 c, $63 c, $00 c,
    $7E c, $66 c, $00 c,
    $CE c, $7C c, $00 c,
    $C6 c, $66 c, $00 c,
    $C6 c, $63 c, $00 c,
    $C6 c, $63 c, $00 c,
    $C6 c, $63 c, $00 c,
    $CE c, $67 c, $00 c,
    $7E c, $7E c, $00 c,
    $36 c, $7C c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

  \   mS
    $00 c, $00 c, $00 c,
    $00 c, $03 c, $E0 c,
    $00 c, $07 c, $F0 c,
    $00 c, $0E c, $38 c,
    $00 c, $0C c, $18 c,
    $00 c, $0C c, $00 c,
    $00 c, $0E c, $00 c,
    $00 c, $07 c, $80 c,
    $DD c, $C3 c, $E0 c,
    $EE c, $C0 c, $F0 c,
    $CC c, $C0 c, $38 c,
    $CC c, $C0 c, $18 c,
    $CC c, $CC c, $18 c,
    $CC c, $CE c, $38 c,
    $CC c, $C7 c, $F0 c,
    $CC c, $C3 c, $E0 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

\   nS
    $00 c, $00 c, $00 c,
    $00 c, $1F c, $00 c,
    $00 c, $3F c, $80 c,
    $00 c, $71 c, $C0 c,
    $00 c, $60 c, $C0 c,
    $00 c, $60 c, $00 c,
    $00 c, $70 c, $00 c,
    $00 c, $3C c, $00 c,
    $DE c, $1F c, $00 c,
    $E6 c, $07 c, $80 c,
    $C6 c, $01 c, $C0 c,
    $C6 c, $00 c, $C0 c,
    $C6 c, $60 c, $C0 c,
    $C6 c, $71 c, $C0 c,
    $C6 c, $3F c, $80 c,
    $C6 c, $1F c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

\   Ohm_z
    $00 c, $00 c, $00 c,
    $1F c, $80 c, $00 c,
    $3F c, $C0 c, $00 c,
    $70 c, $E0 c, $00 c,
    $E0 c, $70 c, $00 c,
    $C0 c, $30 c, $00 c,
    $C0 c, $30 c, $00 c,
    $C0 c, $30 c, $00 c,
    $C0 c, $30 c, $00 c,
    $C0 c, $33 c, $FC c,
    $C0 c, $33 c, $FC c,
    $60 c, $60 c, $18 c,
    $30 c, $C0 c, $30 c,
    $10 c, $80 c, $60 c,
    $F0 c, $F0 c, $60 c,
    $F0 c, $F0 c, $C0 c,
    $00 c, $01 c, $80 c,
    $00 c, $03 c, $FC c,
    $00 c, $03 c, $FC c,
    $00 c, $00 c, $00 c,
    $00 c, $00 c, $00 c,

calign

\ @EOF
