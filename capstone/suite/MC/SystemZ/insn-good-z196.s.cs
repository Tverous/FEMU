# CS_ARCH_SYSZ, 0, None
0xec,0x00,0x80,0x00,0x00,0xd9 = aghik %r0, %r0, -32768
0xec,0x00,0xff,0xff,0x00,0xd9 = aghik %r0, %r0, -1
0xec,0x00,0x00,0x00,0x00,0xd9 = aghik %r0, %r0, 0
0xec,0x00,0x00,0x01,0x00,0xd9 = aghik %r0, %r0, 1
0xec,0x00,0x7f,0xff,0x00,0xd9 = aghik %r0, %r0, 32767
0xec,0x0f,0x00,0x00,0x00,0xd9 = aghik %r0, %r15, 0
0xec,0xf0,0x00,0x00,0x00,0xd9 = aghik %r15, %r0, 0
0xec,0x78,0xff,0xf0,0x00,0xd9 = aghik %r7, %r8, -16
0xb9,0xe8,0x00,0x00 = agrk %r0, %r0, %r0
0xb9,0xe8,0xf0,0x00 = agrk %r0, %r0, %r15
0xb9,0xe8,0x00,0x0f = agrk %r0, %r15, %r0
0xb9,0xe8,0x00,0xf0 = agrk %r15, %r0, %r0
0xb9,0xe8,0x90,0x78 = agrk %r7, %r8, %r9
0xec,0x00,0x80,0x00,0x00,0xd8 = ahik %r0, %r0, -32768
0xec,0x00,0xff,0xff,0x00,0xd8 = ahik %r0, %r0, -1
0xec,0x00,0x00,0x00,0x00,0xd8 = ahik %r0, %r0, 0
0xec,0x00,0x00,0x01,0x00,0xd8 = ahik %r0, %r0, 1
0xec,0x00,0x7f,0xff,0x00,0xd8 = ahik %r0, %r0, 32767
0xec,0x0f,0x00,0x00,0x00,0xd8 = ahik %r0, %r15, 0
0xec,0xf0,0x00,0x00,0x00,0xd8 = ahik %r15, %r0, 0
0xec,0x78,0xff,0xf0,0x00,0xd8 = ahik %r7, %r8, -16
0xcc,0x08,0x80,0x00,0x00,0x00 = aih %r0, -2147483648
0xcc,0x08,0xff,0xff,0xff,0xff = aih %r0, -1
0xcc,0x08,0x00,0x00,0x00,0x00 = aih %r0, 0
0xcc,0x08,0x00,0x00,0x00,0x01 = aih %r0, 1
0xcc,0x08,0x7f,0xff,0xff,0xff = aih %r0, 2147483647
0xcc,0xf8,0x00,0x00,0x00,0x00 = aih %r15, 0
0xec,0x00,0x80,0x00,0x00,0xdb = alghsik %r0, %r0, -32768
0xec,0x00,0xff,0xff,0x00,0xdb = alghsik %r0, %r0, -1
0xec,0x00,0x00,0x00,0x00,0xdb = alghsik %r0, %r0, 0
0xec,0x00,0x00,0x01,0x00,0xdb = alghsik %r0, %r0, 1
0xec,0x00,0x7f,0xff,0x00,0xdb = alghsik %r0, %r0, 32767
0xec,0x0f,0x00,0x00,0x00,0xdb = alghsik %r0, %r15, 0
0xec,0xf0,0x00,0x00,0x00,0xdb = alghsik %r15, %r0, 0
0xec,0x78,0xff,0xf0,0x00,0xdb = alghsik %r7, %r8, -16
0xb9,0xea,0x00,0x00 = algrk %r0, %r0, %r0
0xb9,0xea,0xf0,0x00 = algrk %r0, %r0, %r15
0xb9,0xea,0x00,0x0f = algrk %r0, %r15, %r0
0xb9,0xea,0x00,0xf0 = algrk %r15, %r0, %r0
0xb9,0xea,0x90,0x78 = algrk %r7, %r8, %r9
0xec,0x00,0x80,0x00,0x00,0xda = alhsik %r0, %r0, -32768
0xec,0x00,0xff,0xff,0x00,0xda = alhsik %r0, %r0, -1
0xec,0x00,0x00,0x00,0x00,0xda = alhsik %r0, %r0, 0
0xec,0x00,0x00,0x01,0x00,0xda = alhsik %r0, %r0, 1
0xec,0x00,0x7f,0xff,0x00,0xda = alhsik %r0, %r0, 32767
0xec,0x0f,0x00,0x00,0x00,0xda = alhsik %r0, %r15, 0
0xec,0xf0,0x00,0x00,0x00,0xda = alhsik %r15, %r0, 0
0xec,0x78,0xff,0xf0,0x00,0xda = alhsik %r7, %r8, -16
0xb9,0xfa,0x00,0x00 = alrk %r0, %r0, %r0
0xb9,0xfa,0xf0,0x00 = alrk %r0, %r0, %r15
0xb9,0xfa,0x00,0x0f = alrk %r0, %r15, %r0
0xb9,0xfa,0x00,0xf0 = alrk %r15, %r0, %r0
0xb9,0xfa,0x90,0x78 = alrk %r7, %r8, %r9
0xb9,0xf8,0x00,0x00 = ark %r0, %r0, %r0
0xb9,0xf8,0xf0,0x00 = ark %r0, %r0, %r15
0xb9,0xf8,0x00,0x0f = ark %r0, %r15, %r0
0xb9,0xf8,0x00,0xf0 = ark %r15, %r0, %r0
0xb9,0xf8,0x90,0x78 = ark %r7, %r8, %r9
0xb3,0x91,0x00,0x00 = cdlfbr %f0, 0, %r0, 0
0xb3,0x91,0x0f,0x00 = cdlfbr %f0, 0, %r0, 15
0xb3,0x91,0x00,0x0f = cdlfbr %f0, 0, %r15, 0
0xb3,0x91,0xf0,0x00 = cdlfbr %f0, 15, %r0, 0
0xb3,0x91,0x57,0x46 = cdlfbr %f4, 5, %r6, 7
0xb3,0x91,0x00,0xf0 = cdlfbr %f15, 0, %r0, 0
0xb3,0xa1,0x00,0x00 = cdlgbr %f0, 0, %r0, 0
0xb3,0xa1,0x0f,0x00 = cdlgbr %f0, 0, %r0, 15
0xb3,0xa1,0x00,0x0f = cdlgbr %f0, 0, %r15, 0
0xb3,0xa1,0xf0,0x00 = cdlgbr %f0, 15, %r0, 0
0xb3,0xa1,0x57,0x46 = cdlgbr %f4, 5, %r6, 7
0xb3,0xa1,0x00,0xf0 = cdlgbr %f15, 0, %r0, 0
0xb3,0x90,0x00,0x00 = celfbr %f0, 0, %r0, 0
0xb3,0x90,0x0f,0x00 = celfbr %f0, 0, %r0, 15
0xb3,0x90,0x00,0x0f = celfbr %f0, 0, %r15, 0
0xb3,0x90,0xf0,0x00 = celfbr %f0, 15, %r0, 0
0xb3,0x90,0x57,0x46 = celfbr %f4, 5, %r6, 7
0xb3,0x90,0x00,0xf0 = celfbr %f15, 0, %r0, 0
0xb3,0xa0,0x00,0x00 = celgbr %f0, 0, %r0, 0
0xb3,0xa0,0x0f,0x00 = celgbr %f0, 0, %r0, 15
0xb3,0xa0,0x00,0x0f = celgbr %f0, 0, %r15, 0
0xb3,0xa0,0xf0,0x00 = celgbr %f0, 15, %r0, 0
0xb3,0xa0,0x57,0x46 = celgbr %f4, 5, %r6, 7
0xb3,0xa0,0x00,0xf0 = celgbr %f15, 0, %r0, 0
0xe3,0x00,0x00,0x00,0x80,0xcd = chf %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xcd = chf %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xcd = chf %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xcd = chf %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xcd = chf %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xcd = chf %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xcd = chf %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xcd = chf %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xcd = chf %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xcd = chf %r15, 0
0xcc,0x0d,0x80,0x00,0x00,0x00 = cih %r0, -2147483648
0xcc,0x0d,0xff,0xff,0xff,0xff = cih %r0, -1
0xcc,0x0d,0x00,0x00,0x00,0x00 = cih %r0, 0
0xcc,0x0d,0x00,0x00,0x00,0x01 = cih %r0, 1
0xcc,0x0d,0x7f,0xff,0xff,0xff = cih %r0, 2147483647
0xcc,0xfd,0x00,0x00,0x00,0x00 = cih %r15, 0
0xb3,0x9d,0x00,0x00 = clfdbr %r0, 0, %f0, 0
0xb3,0x9d,0x0f,0x00 = clfdbr %r0, 0, %f0, 15
0xb3,0x9d,0x00,0x0f = clfdbr %r0, 0, %f15, 0
0xb3,0x9d,0xf0,0x00 = clfdbr %r0, 15, %f0, 0
0xb3,0x9d,0x57,0x46 = clfdbr %r4, 5, %f6, 7
0xb3,0x9d,0x00,0xf0 = clfdbr %r15, 0, %f0, 0
0xb3,0x9c,0x00,0x00 = clfebr %r0, 0, %f0, 0
0xb3,0x9c,0x0f,0x00 = clfebr %r0, 0, %f0, 15
0xb3,0x9c,0x00,0x0f = clfebr %r0, 0, %f15, 0
0xb3,0x9c,0xf0,0x00 = clfebr %r0, 15, %f0, 0
0xb3,0x9c,0x57,0x46 = clfebr %r4, 5, %f6, 7
0xb3,0x9c,0x00,0xf0 = clfebr %r15, 0, %f0, 0
0xb3,0x9e,0x00,0x00 = clfxbr %r0, 0, %f0, 0
0xb3,0x9e,0x0f,0x00 = clfxbr %r0, 0, %f0, 15
0xb3,0x9e,0x00,0x0d = clfxbr %r0, 0, %f13, 0
0xb3,0x9e,0xf0,0x00 = clfxbr %r0, 15, %f0, 0
0xb3,0x9e,0x59,0x78 = clfxbr %r7, 5, %f8, 9
0xb3,0x9e,0x00,0xf0 = clfxbr %r15, 0, %f0, 0
0xb3,0xad,0x00,0x00 = clgdbr %r0, 0, %f0, 0
0xb3,0xad,0x0f,0x00 = clgdbr %r0, 0, %f0, 15
0xb3,0xad,0x00,0x0f = clgdbr %r0, 0, %f15, 0
0xb3,0xad,0xf0,0x00 = clgdbr %r0, 15, %f0, 0
0xb3,0xad,0x57,0x46 = clgdbr %r4, 5, %f6, 7
0xb3,0xad,0x00,0xf0 = clgdbr %r15, 0, %f0, 0
0xb3,0xac,0x00,0x00 = clgebr %r0, 0, %f0, 0
0xb3,0xac,0x0f,0x00 = clgebr %r0, 0, %f0, 15
0xb3,0xac,0x00,0x0f = clgebr %r0, 0, %f15, 0
0xb3,0xac,0xf0,0x00 = clgebr %r0, 15, %f0, 0
0xb3,0xac,0x57,0x46 = clgebr %r4, 5, %f6, 7
0xb3,0xac,0x00,0xf0 = clgebr %r15, 0, %f0, 0
0xb3,0xae,0x00,0x00 = clgxbr %r0, 0, %f0, 0
0xb3,0xae,0x0f,0x00 = clgxbr %r0, 0, %f0, 15
0xb3,0xae,0x00,0x0d = clgxbr %r0, 0, %f13, 0
0xb3,0xae,0xf0,0x00 = clgxbr %r0, 15, %f0, 0
0xb3,0xae,0x59,0x78 = clgxbr %r7, 5, %f8, 9
0xb3,0xae,0x00,0xf0 = clgxbr %r15, 0, %f0, 0
0xe3,0x00,0x00,0x00,0x80,0xcf = clhf %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xcf = clhf %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xcf = clhf %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xcf = clhf %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xcf = clhf %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xcf = clhf %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xcf = clhf %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xcf = clhf %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xcf = clhf %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xcf = clhf %r15, 0
0xcc,0x0f,0x00,0x00,0x00,0x00 = clih %r0, 0
0xcc,0x0f,0x00,0x00,0x00,0x01 = clih %r0, 1
0xcc,0x0f,0xff,0xff,0xff,0xff = clih %r0, 4294967295
0xcc,0xff,0x00,0x00,0x00,0x00 = clih %r15, 0
0xb3,0x92,0x00,0x00 = cxlfbr %f0, 0, %r0, 0
0xb3,0x92,0x0f,0x00 = cxlfbr %f0, 0, %r0, 15
0xb3,0x92,0x00,0x0f = cxlfbr %f0, 0, %r15, 0
0xb3,0x92,0xf0,0x00 = cxlfbr %f0, 15, %r0, 0
0xb3,0x92,0x5a,0x49 = cxlfbr %f4, 5, %r9, 10
0xb3,0x92,0x00,0xd0 = cxlfbr %f13, 0, %r0, 0
0xb3,0xa2,0x00,0x00 = cxlgbr %f0, 0, %r0, 0
0xb3,0xa2,0x0f,0x00 = cxlgbr %f0, 0, %r0, 15
0xb3,0xa2,0x00,0x0f = cxlgbr %f0, 0, %r15, 0
0xb3,0xa2,0xf0,0x00 = cxlgbr %f0, 15, %r0, 0
0xb3,0xa2,0x5a,0x49 = cxlgbr %f4, 5, %r9, 10
0xb3,0xa2,0x00,0xd0 = cxlgbr %f13, 0, %r0, 0
0xb3,0x5f,0x00,0x00 = fidbra %f0, 0, %f0, 0
0xb3,0x5f,0x0f,0x00 = fidbra %f0, 0, %f0, 15
0xb3,0x5f,0x00,0x0f = fidbra %f0, 0, %f15, 0
0xb3,0x5f,0xf0,0x00 = fidbra %f0, 15, %f0, 0
0xb3,0x5f,0x57,0x46 = fidbra %f4, 5, %f6, 7
0xb3,0x5f,0x00,0xf0 = fidbra %f15, 0, %f0, 0
0xb3,0x57,0x00,0x00 = fiebra %f0, 0, %f0, 0
0xb3,0x57,0x0f,0x00 = fiebra %f0, 0, %f0, 15
0xb3,0x57,0x00,0x0f = fiebra %f0, 0, %f15, 0
0xb3,0x57,0xf0,0x00 = fiebra %f0, 15, %f0, 0
0xb3,0x57,0x57,0x46 = fiebra %f4, 5, %f6, 7
0xb3,0x57,0x00,0xf0 = fiebra %f15, 0, %f0, 0
0xb3,0x47,0x00,0x00 = fixbra %f0, 0, %f0, 0
0xb3,0x47,0x0f,0x00 = fixbra %f0, 0, %f0, 15
0xb3,0x47,0x00,0x0d = fixbra %f0, 0, %f13, 0
0xb3,0x47,0xf0,0x00 = fixbra %f0, 15, %f0, 0
0xb3,0x47,0x59,0x48 = fixbra %f4, 5, %f8, 9
0xb3,0x47,0x00,0xd0 = fixbra %f13, 0, %f0, 0
0xeb,0x00,0x00,0x00,0x80,0xf8 = laa %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xf8 = laa %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xf8 = laa %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xf8 = laa %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xf8 = laa %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xf8 = laa %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xf8 = laa %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xf8 = laa %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xf8 = laa %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xf8 = laa %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xf8 = laa %r15, %r0, 0
0xeb,0x00,0x00,0x00,0x80,0xe8 = laag %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xe8 = laag %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xe8 = laag %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xe8 = laag %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xe8 = laag %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xe8 = laag %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xe8 = laag %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xe8 = laag %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xe8 = laag %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xe8 = laag %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xe8 = laag %r15, %r0, 0
0xeb,0x00,0x00,0x00,0x80,0xfa = laal %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xfa = laal %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xfa = laal %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xfa = laal %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xfa = laal %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xfa = laal %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xfa = laal %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xfa = laal %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xfa = laal %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xfa = laal %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xfa = laal %r15, %r0, 0
0xeb,0x00,0x00,0x00,0x80,0xea = laalg %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xea = laalg %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xea = laalg %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xea = laalg %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xea = laalg %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xea = laalg %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xea = laalg %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xea = laalg %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xea = laalg %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xea = laalg %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xea = laalg %r15, %r0, 0
0xeb,0x00,0x00,0x00,0x80,0xf4 = lan %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xf4 = lan %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xf4 = lan %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xf4 = lan %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xf4 = lan %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xf4 = lan %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xf4 = lan %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xf4 = lan %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xf4 = lan %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xf4 = lan %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xf4 = lan %r15, %r0, 0
0xeb,0x00,0x00,0x00,0x80,0xe4 = lang %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xe4 = lang %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xe4 = lang %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xe4 = lang %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xe4 = lang %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xe4 = lang %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xe4 = lang %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xe4 = lang %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xe4 = lang %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xe4 = lang %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xe4 = lang %r15, %r0, 0
0xeb,0x00,0x00,0x00,0x80,0xf6 = lao %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xf6 = lao %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xf6 = lao %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xf6 = lao %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xf6 = lao %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xf6 = lao %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xf6 = lao %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xf6 = lao %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xf6 = lao %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xf6 = lao %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xf6 = lao %r15, %r0, 0
0xeb,0x00,0x00,0x00,0x80,0xe6 = laog %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xe6 = laog %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xe6 = laog %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xe6 = laog %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xe6 = laog %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xe6 = laog %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xe6 = laog %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xe6 = laog %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xe6 = laog %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xe6 = laog %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xe6 = laog %r15, %r0, 0
0xeb,0x00,0x00,0x00,0x80,0xf7 = lax %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xf7 = lax %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xf7 = lax %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xf7 = lax %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xf7 = lax %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xf7 = lax %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xf7 = lax %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xf7 = lax %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xf7 = lax %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xf7 = lax %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xf7 = lax %r15, %r0, 0
0xeb,0x00,0x00,0x00,0x80,0xe7 = laxg %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xe7 = laxg %r0, %r0, -1
0xeb,0x00,0x00,0x00,0x00,0xe7 = laxg %r0, %r0, 0
0xeb,0x00,0x00,0x01,0x00,0xe7 = laxg %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xe7 = laxg %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xe7 = laxg %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xe7 = laxg %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xe7 = laxg %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xe7 = laxg %r0, %r0, 524287(%r15)
0xeb,0x0f,0x00,0x00,0x00,0xe7 = laxg %r0, %r15, 0
0xeb,0xf0,0x00,0x00,0x00,0xe7 = laxg %r15, %r0, 0
0xe3,0x00,0x00,0x00,0x80,0xc0 = lbh %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xc0 = lbh %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xc0 = lbh %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xc0 = lbh %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xc0 = lbh %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xc0 = lbh %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xc0 = lbh %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xc0 = lbh %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xc0 = lbh %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xc0 = lbh %r15, 0
0xe3,0x00,0x00,0x00,0x80,0xca = lfh %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xca = lfh %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xca = lfh %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xca = lfh %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xca = lfh %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xca = lfh %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xca = lfh %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xca = lfh %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xca = lfh %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xca = lfh %r15, 0
0xe3,0x00,0x00,0x00,0x80,0xc4 = lhh %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xc4 = lhh %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xc4 = lhh %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xc4 = lhh %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xc4 = lhh %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xc4 = lhh %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xc4 = lhh %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xc4 = lhh %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xc4 = lhh %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xc4 = lhh %r15, 0
0xe3,0x00,0x00,0x00,0x80,0xc2 = llch %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xc2 = llch %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xc2 = llch %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xc2 = llch %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xc2 = llch %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xc2 = llch %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xc2 = llch %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xc2 = llch %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xc2 = llch %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xc2 = llch %r15, 0
0xe3,0x00,0x00,0x00,0x80,0xc6 = llhh %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xc6 = llhh %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xc6 = llhh %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xc6 = llhh %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xc6 = llhh %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xc6 = llhh %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xc6 = llhh %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xc6 = llhh %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xc6 = llhh %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xc6 = llhh %r15, 0
0xeb,0x00,0x00,0x00,0x00,0xf2 = loc %r0, 0, 0
0xeb,0x0f,0x00,0x00,0x00,0xf2 = loc %r0, 0, 15
0xeb,0x00,0x00,0x00,0x80,0xf2 = loc %r0, -524288, 0
0xeb,0x00,0x0f,0xff,0x7f,0xf2 = loc %r0, 524287, 0
0xeb,0x00,0x10,0x00,0x00,0xf2 = loc %r0, 0(%r1), 0
0xeb,0x00,0xf0,0x00,0x00,0xf2 = loc %r0, 0(%r15), 0
0xeb,0xf0,0x00,0x00,0x00,0xf2 = loc %r15, 0, 0
0xeb,0x13,0x2f,0xff,0x00,0xf2 = loc %r1, 4095(%r2), 3
0xeb,0x11,0x30,0x02,0x00,0xf2 = loco %r1, 2(%r3)
0xeb,0x12,0x30,0x02,0x00,0xf2 = loch %r1, 2(%r3)
0xeb,0x13,0x30,0x02,0x00,0xf2 = locnle %r1, 2(%r3)
0xeb,0x14,0x30,0x02,0x00,0xf2 = locl %r1, 2(%r3)
0xeb,0x15,0x30,0x02,0x00,0xf2 = locnhe %r1, 2(%r3)
0xeb,0x16,0x30,0x02,0x00,0xf2 = loclh %r1, 2(%r3)
0xeb,0x17,0x30,0x02,0x00,0xf2 = locne %r1, 2(%r3)
0xeb,0x18,0x30,0x02,0x00,0xf2 = loce %r1, 2(%r3)
0xeb,0x19,0x30,0x02,0x00,0xf2 = locnlh %r1, 2(%r3)
0xeb,0x1a,0x30,0x02,0x00,0xf2 = loche %r1, 2(%r3)
0xeb,0x1b,0x30,0x02,0x00,0xf2 = locnl %r1, 2(%r3)
0xeb,0x1c,0x30,0x02,0x00,0xf2 = locle %r1, 2(%r3)
0xeb,0x1d,0x30,0x02,0x00,0xf2 = locnh %r1, 2(%r3)
0xeb,0x1e,0x30,0x02,0x00,0xf2 = locno %r1, 2(%r3)
0xeb,0x00,0x00,0x00,0x00,0xe2 = locg %r0, 0, 0
0xeb,0x0f,0x00,0x00,0x00,0xe2 = locg %r0, 0, 15
0xeb,0x00,0x00,0x00,0x80,0xe2 = locg %r0, -524288, 0
0xeb,0x00,0x0f,0xff,0x7f,0xe2 = locg %r0, 524287, 0
0xeb,0x00,0x10,0x00,0x00,0xe2 = locg %r0, 0(%r1), 0
0xeb,0x00,0xf0,0x00,0x00,0xe2 = locg %r0, 0(%r15), 0
0xeb,0xf0,0x00,0x00,0x00,0xe2 = locg %r15, 0, 0
0xeb,0x13,0x2f,0xff,0x00,0xe2 = locg %r1, 4095(%r2), 3
0xeb,0x11,0x30,0x02,0x00,0xe2 = locgo %r1, 2(%r3)
0xeb,0x12,0x30,0x02,0x00,0xe2 = locgh %r1, 2(%r3)
0xeb,0x13,0x30,0x02,0x00,0xe2 = locgnle %r1, 2(%r3)
0xeb,0x14,0x30,0x02,0x00,0xe2 = locgl %r1, 2(%r3)
0xeb,0x15,0x30,0x02,0x00,0xe2 = locgnhe %r1, 2(%r3)
0xeb,0x16,0x30,0x02,0x00,0xe2 = locglh %r1, 2(%r3)
0xeb,0x17,0x30,0x02,0x00,0xe2 = locgne %r1, 2(%r3)
0xeb,0x18,0x30,0x02,0x00,0xe2 = locge %r1, 2(%r3)
0xeb,0x19,0x30,0x02,0x00,0xe2 = locgnlh %r1, 2(%r3)
0xeb,0x1a,0x30,0x02,0x00,0xe2 = locghe %r1, 2(%r3)
0xeb,0x1b,0x30,0x02,0x00,0xe2 = locgnl %r1, 2(%r3)
0xeb,0x1c,0x30,0x02,0x00,0xe2 = locgle %r1, 2(%r3)
0xeb,0x1d,0x30,0x02,0x00,0xe2 = locgnh %r1, 2(%r3)
0xeb,0x1e,0x30,0x02,0x00,0xe2 = locgno %r1, 2(%r3)
0xb9,0xe2,0x00,0x12 = locgr %r1, %r2, 0
0xb9,0xe2,0xf0,0x12 = locgr %r1, %r2, 15
0xb9,0xe2,0x10,0x13 = locgro %r1, %r3
0xb9,0xe2,0x20,0x13 = locgrh %r1, %r3
0xb9,0xe2,0x30,0x13 = locgrnle %r1, %r3
0xb9,0xe2,0x40,0x13 = locgrl %r1, %r3
0xb9,0xe2,0x50,0x13 = locgrnhe %r1, %r3
0xb9,0xe2,0x60,0x13 = locgrlh %r1, %r3
0xb9,0xe2,0x70,0x13 = locgrne %r1, %r3
0xb9,0xe2,0x80,0x13 = locgre %r1, %r3
0xb9,0xe2,0x90,0x13 = locgrnlh %r1, %r3
0xb9,0xe2,0xa0,0x13 = locgrhe %r1, %r3
0xb9,0xe2,0xb0,0x13 = locgrnl %r1, %r3
0xb9,0xe2,0xc0,0x13 = locgrle %r1, %r3
0xb9,0xe2,0xd0,0x13 = locgrnh %r1, %r3
0xb9,0xe2,0xe0,0x13 = locgrno %r1, %r3
0xb9,0xf2,0x00,0x12 = locr %r1, %r2, 0
0xb9,0xf2,0xf0,0x12 = locr %r1, %r2, 15
0xb9,0xf2,0x10,0x13 = locro %r1, %r3
0xb9,0xf2,0x20,0x13 = locrh %r1, %r3
0xb9,0xf2,0x30,0x13 = locrnle %r1, %r3
0xb9,0xf2,0x40,0x13 = locrl %r1, %r3
0xb9,0xf2,0x50,0x13 = locrnhe %r1, %r3
0xb9,0xf2,0x60,0x13 = locrlh %r1, %r3
0xb9,0xf2,0x70,0x13 = locrne %r1, %r3
0xb9,0xf2,0x80,0x13 = locre %r1, %r3
0xb9,0xf2,0x90,0x13 = locrnlh %r1, %r3
0xb9,0xf2,0xa0,0x13 = locrhe %r1, %r3
0xb9,0xf2,0xb0,0x13 = locrnl %r1, %r3
0xb9,0xf2,0xc0,0x13 = locrle %r1, %r3
0xb9,0xf2,0xd0,0x13 = locrnh %r1, %r3
0xb9,0xf2,0xe0,0x13 = locrno %r1, %r3
0xb9,0xe4,0x00,0x00 = ngrk %r0, %r0, %r0
0xb9,0xe4,0xf0,0x00 = ngrk %r0, %r0, %r15
0xb9,0xe4,0x00,0x0f = ngrk %r0, %r15, %r0
0xb9,0xe4,0x00,0xf0 = ngrk %r15, %r0, %r0
0xb9,0xe4,0x90,0x78 = ngrk %r7, %r8, %r9
0xb9,0xf4,0x00,0x00 = nrk %r0, %r0, %r0
0xb9,0xf4,0xf0,0x00 = nrk %r0, %r0, %r15
0xb9,0xf4,0x00,0x0f = nrk %r0, %r15, %r0
0xb9,0xf4,0x00,0xf0 = nrk %r15, %r0, %r0
0xb9,0xf4,0x90,0x78 = nrk %r7, %r8, %r9
0xb9,0xe6,0x00,0x00 = ogrk %r0, %r0, %r0
0xb9,0xe6,0xf0,0x00 = ogrk %r0, %r0, %r15
0xb9,0xe6,0x00,0x0f = ogrk %r0, %r15, %r0
0xb9,0xe6,0x00,0xf0 = ogrk %r15, %r0, %r0
0xb9,0xe6,0x90,0x78 = ogrk %r7, %r8, %r9
0xb9,0xf6,0x00,0x00 = ork %r0, %r0, %r0
0xb9,0xf6,0xf0,0x00 = ork %r0, %r0, %r15
0xb9,0xf6,0x00,0x0f = ork %r0, %r15, %r0
0xb9,0xf6,0x00,0xf0 = ork %r15, %r0, %r0
0xb9,0xf6,0x90,0x78 = ork %r7, %r8, %r9
0xec,0x00,0x00,0x00,0x00,0x5d = risbhg %r0, %r0, 0, 0, 0
0xec,0x00,0x00,0x00,0x3f,0x5d = risbhg %r0, %r0, 0, 0, 63
0xec,0x00,0x00,0xff,0x00,0x5d = risbhg %r0, %r0, 0, 255, 0
0xec,0x00,0xff,0x00,0x00,0x5d = risbhg %r0, %r0, 255, 0, 0
0xec,0x0f,0x00,0x00,0x00,0x5d = risbhg %r0, %r15, 0, 0, 0
0xec,0xf0,0x00,0x00,0x00,0x5d = risbhg %r15, %r0, 0, 0, 0
0xec,0x45,0x06,0x07,0x08,0x5d = risbhg %r4, %r5, 6, 7, 8
0xec,0x00,0x00,0x00,0x00,0x51 = risblg %r0, %r0, 0, 0, 0
0xec,0x00,0x00,0x00,0x3f,0x51 = risblg %r0, %r0, 0, 0, 63
0xec,0x00,0x00,0xff,0x00,0x51 = risblg %r0, %r0, 0, 255, 0
0xec,0x00,0xff,0x00,0x00,0x51 = risblg %r0, %r0, 255, 0, 0
0xec,0x0f,0x00,0x00,0x00,0x51 = risblg %r0, %r15, 0, 0, 0
0xec,0xf0,0x00,0x00,0x00,0x51 = risblg %r15, %r0, 0, 0, 0
0xec,0x45,0x06,0x07,0x08,0x51 = risblg %r4, %r5, 6, 7, 8
0xb9,0xe9,0x00,0x00 = sgrk %r0, %r0, %r0
0xb9,0xe9,0xf0,0x00 = sgrk %r0, %r0, %r15
0xb9,0xe9,0x00,0x0f = sgrk %r0, %r15, %r0
0xb9,0xe9,0x00,0xf0 = sgrk %r15, %r0, %r0
0xb9,0xe9,0x90,0x78 = sgrk %r7, %r8, %r9
0xb9,0xeb,0x00,0x00 = slgrk %r0, %r0, %r0
0xb9,0xeb,0xf0,0x00 = slgrk %r0, %r0, %r15
0xb9,0xeb,0x00,0x0f = slgrk %r0, %r15, %r0
0xb9,0xeb,0x00,0xf0 = slgrk %r15, %r0, %r0
0xb9,0xeb,0x90,0x78 = slgrk %r7, %r8, %r9
0xb9,0xfb,0x00,0x00 = slrk %r0, %r0, %r0
0xb9,0xfb,0xf0,0x00 = slrk %r0, %r0, %r15
0xb9,0xfb,0x00,0x0f = slrk %r0, %r15, %r0
0xb9,0xfb,0x00,0xf0 = slrk %r15, %r0, %r0
0xb9,0xfb,0x90,0x78 = slrk %r7, %r8, %r9
0xeb,0x00,0x00,0x00,0x00,0xdf = sllk %r0, %r0, 0
0xeb,0xf1,0x00,0x00,0x00,0xdf = sllk %r15, %r1, 0
0xeb,0x1f,0x00,0x00,0x00,0xdf = sllk %r1, %r15, 0
0xeb,0xff,0x00,0x00,0x00,0xdf = sllk %r15, %r15, 0
0xeb,0x00,0x00,0x00,0x80,0xdf = sllk %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xdf = sllk %r0, %r0, -1
0xeb,0x00,0x00,0x01,0x00,0xdf = sllk %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xdf = sllk %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xdf = sllk %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xdf = sllk %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xdf = sllk %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xdf = sllk %r0, %r0, 524287(%r15)
0xeb,0x00,0x00,0x00,0x00,0xdc = srak %r0, %r0, 0
0xeb,0xf1,0x00,0x00,0x00,0xdc = srak %r15, %r1, 0
0xeb,0x1f,0x00,0x00,0x00,0xdc = srak %r1, %r15, 0
0xeb,0xff,0x00,0x00,0x00,0xdc = srak %r15, %r15, 0
0xeb,0x00,0x00,0x00,0x80,0xdc = srak %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xdc = srak %r0, %r0, -1
0xeb,0x00,0x00,0x01,0x00,0xdc = srak %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xdc = srak %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xdc = srak %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xdc = srak %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xdc = srak %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xdc = srak %r0, %r0, 524287(%r15)
0xb9,0xf9,0x00,0x00 = srk %r0, %r0, %r0
0xb9,0xf9,0xf0,0x00 = srk %r0, %r0, %r15
0xb9,0xf9,0x00,0x0f = srk %r0, %r15, %r0
0xb9,0xf9,0x00,0xf0 = srk %r15, %r0, %r0
0xb9,0xf9,0x90,0x78 = srk %r7, %r8, %r9
0xeb,0x00,0x00,0x00,0x00,0xde = srlk %r0, %r0, 0
0xeb,0xf1,0x00,0x00,0x00,0xde = srlk %r15, %r1, 0
0xeb,0x1f,0x00,0x00,0x00,0xde = srlk %r1, %r15, 0
0xeb,0xff,0x00,0x00,0x00,0xde = srlk %r15, %r15, 0
0xeb,0x00,0x00,0x00,0x80,0xde = srlk %r0, %r0, -524288
0xeb,0x00,0x0f,0xff,0xff,0xde = srlk %r0, %r0, -1
0xeb,0x00,0x00,0x01,0x00,0xde = srlk %r0, %r0, 1
0xeb,0x00,0x0f,0xff,0x7f,0xde = srlk %r0, %r0, 524287
0xeb,0x00,0x10,0x00,0x00,0xde = srlk %r0, %r0, 0(%r1)
0xeb,0x00,0xf0,0x00,0x00,0xde = srlk %r0, %r0, 0(%r15)
0xeb,0x00,0x1f,0xff,0x7f,0xde = srlk %r0, %r0, 524287(%r1)
0xeb,0x00,0xff,0xff,0x7f,0xde = srlk %r0, %r0, 524287(%r15)
0xe3,0x00,0x00,0x00,0x80,0xc3 = stch %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xc3 = stch %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xc3 = stch %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xc3 = stch %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xc3 = stch %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xc3 = stch %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xc3 = stch %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xc3 = stch %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xc3 = stch %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xc3 = stch %r15, 0
0xe3,0x00,0x00,0x00,0x80,0xc7 = sthh %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xc7 = sthh %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xc7 = sthh %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xc7 = sthh %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xc7 = sthh %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xc7 = sthh %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xc7 = sthh %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xc7 = sthh %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xc7 = sthh %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xc7 = sthh %r15, 0
0xe3,0x00,0x00,0x00,0x80,0xcb = stfh %r0, -524288
0xe3,0x00,0x0f,0xff,0xff,0xcb = stfh %r0, -1
0xe3,0x00,0x00,0x00,0x00,0xcb = stfh %r0, 0
0xe3,0x00,0x00,0x01,0x00,0xcb = stfh %r0, 1
0xe3,0x00,0x0f,0xff,0x7f,0xcb = stfh %r0, 524287
0xe3,0x00,0x10,0x00,0x00,0xcb = stfh %r0, 0(%r1)
0xe3,0x00,0xf0,0x00,0x00,0xcb = stfh %r0, 0(%r15)
0xe3,0x01,0xff,0xff,0x7f,0xcb = stfh %r0, 524287(%r1,%r15)
0xe3,0x0f,0x1f,0xff,0x7f,0xcb = stfh %r0, 524287(%r15,%r1)
0xe3,0xf0,0x00,0x00,0x00,0xcb = stfh %r15, 0
0xeb,0x00,0x00,0x00,0x00,0xf3 = stoc %r0, 0, 0
0xeb,0x0f,0x00,0x00,0x00,0xf3 = stoc %r0, 0, 15
0xeb,0x00,0x00,0x00,0x80,0xf3 = stoc %r0, -524288, 0
0xeb,0x00,0x0f,0xff,0x7f,0xf3 = stoc %r0, 524287, 0
0xeb,0x00,0x10,0x00,0x00,0xf3 = stoc %r0, 0(%r1), 0
0xeb,0x00,0xf0,0x00,0x00,0xf3 = stoc %r0, 0(%r15), 0
0xeb,0xf0,0x00,0x00,0x00,0xf3 = stoc %r15, 0, 0
0xeb,0x13,0x2f,0xff,0x00,0xf3 = stoc %r1, 4095(%r2), 3
0xeb,0x11,0x30,0x02,0x00,0xf3 = stoco %r1, 2(%r3)
0xeb,0x12,0x30,0x02,0x00,0xf3 = stoch %r1, 2(%r3)
0xeb,0x13,0x30,0x02,0x00,0xf3 = stocnle %r1, 2(%r3)
0xeb,0x14,0x30,0x02,0x00,0xf3 = stocl %r1, 2(%r3)
0xeb,0x15,0x30,0x02,0x00,0xf3 = stocnhe %r1, 2(%r3)
0xeb,0x16,0x30,0x02,0x00,0xf3 = stoclh %r1, 2(%r3)
0xeb,0x17,0x30,0x02,0x00,0xf3 = stocne %r1, 2(%r3)
0xeb,0x18,0x30,0x02,0x00,0xf3 = stoce %r1, 2(%r3)
0xeb,0x19,0x30,0x02,0x00,0xf3 = stocnlh %r1, 2(%r3)
0xeb,0x1a,0x30,0x02,0x00,0xf3 = stoche %r1, 2(%r3)
0xeb,0x1b,0x30,0x02,0x00,0xf3 = stocnl %r1, 2(%r3)
0xeb,0x1c,0x30,0x02,0x00,0xf3 = stocle %r1, 2(%r3)
0xeb,0x1d,0x30,0x02,0x00,0xf3 = stocnh %r1, 2(%r3)
0xeb,0x1e,0x30,0x02,0x00,0xf3 = stocno %r1, 2(%r3)
0xeb,0x00,0x00,0x00,0x00,0xe3 = stocg %r0, 0, 0
0xeb,0x0f,0x00,0x00,0x00,0xe3 = stocg %r0, 0, 15
0xeb,0x00,0x00,0x00,0x80,0xe3 = stocg %r0, -524288, 0
0xeb,0x00,0x0f,0xff,0x7f,0xe3 = stocg %r0, 524287, 0
0xeb,0x00,0x10,0x00,0x00,0xe3 = stocg %r0, 0(%r1), 0
0xeb,0x00,0xf0,0x00,0x00,0xe3 = stocg %r0, 0(%r15), 0
0xeb,0xf0,0x00,0x00,0x00,0xe3 = stocg %r15, 0, 0
0xeb,0x13,0x2f,0xff,0x00,0xe3 = stocg %r1, 4095(%r2), 3
0xeb,0x11,0x30,0x02,0x00,0xe3 = stocgo %r1, 2(%r3)
0xeb,0x12,0x30,0x02,0x00,0xe3 = stocgh %r1, 2(%r3)
0xeb,0x13,0x30,0x02,0x00,0xe3 = stocgnle %r1, 2(%r3)
0xeb,0x14,0x30,0x02,0x00,0xe3 = stocgl %r1, 2(%r3)
0xeb,0x15,0x30,0x02,0x00,0xe3 = stocgnhe %r1, 2(%r3)
0xeb,0x16,0x30,0x02,0x00,0xe3 = stocglh %r1, 2(%r3)
0xeb,0x17,0x30,0x02,0x00,0xe3 = stocgne %r1, 2(%r3)
0xeb,0x18,0x30,0x02,0x00,0xe3 = stocge %r1, 2(%r3)
0xeb,0x19,0x30,0x02,0x00,0xe3 = stocgnlh %r1, 2(%r3)
0xeb,0x1a,0x30,0x02,0x00,0xe3 = stocghe %r1, 2(%r3)
0xeb,0x1b,0x30,0x02,0x00,0xe3 = stocgnl %r1, 2(%r3)
0xeb,0x1c,0x30,0x02,0x00,0xe3 = stocgle %r1, 2(%r3)
0xeb,0x1d,0x30,0x02,0x00,0xe3 = stocgnh %r1, 2(%r3)
0xeb,0x1e,0x30,0x02,0x00,0xe3 = stocgno %r1, 2(%r3)
0xb9,0xe7,0x00,0x00 = xgrk %r0, %r0, %r0
0xb9,0xe7,0xf0,0x00 = xgrk %r0, %r0, %r15
0xb9,0xe7,0x00,0x0f = xgrk %r0, %r15, %r0
0xb9,0xe7,0x00,0xf0 = xgrk %r15, %r0, %r0
0xb9,0xe7,0x90,0x78 = xgrk %r7, %r8, %r9
0xb9,0xf7,0x00,0x00 = xrk %r0, %r0, %r0
0xb9,0xf7,0xf0,0x00 = xrk %r0, %r0, %r15
0xb9,0xf7,0x00,0x0f = xrk %r0, %r15, %r0
0xb9,0xf7,0x00,0xf0 = xrk %r15, %r0, %r0
0xb9,0xf7,0x90,0x78 = xrk %r7, %r8, %r9