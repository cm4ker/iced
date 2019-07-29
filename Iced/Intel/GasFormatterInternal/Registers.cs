/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_GAS_FORMATTER && !NO_FORMATTER
namespace Iced.Intel.GasFormatterInternal {
	static class Registers {
		public const Register Register_ST = (Register)DecoderConstants.NumberOfRegisters + 0;
		public const int ExtraRegisters = 1;
		public static readonly string[] AllRegisters = new string[DecoderConstants.NumberOfRegisters + 1] {
			"%???",
			"%al",
			"%cl",
			"%dl",
			"%bl",
			"%ah",
			"%ch",
			"%dh",
			"%bh",
			"%spl",
			"%bpl",
			"%sil",
			"%dil",
			"%r8b",
			"%r9b",
			"%r10b",
			"%r11b",
			"%r12b",
			"%r13b",
			"%r14b",
			"%r15b",
			"%ax",
			"%cx",
			"%dx",
			"%bx",
			"%sp",
			"%bp",
			"%si",
			"%di",
			"%r8w",
			"%r9w",
			"%r10w",
			"%r11w",
			"%r12w",
			"%r13w",
			"%r14w",
			"%r15w",
			"%eax",
			"%ecx",
			"%edx",
			"%ebx",
			"%esp",
			"%ebp",
			"%esi",
			"%edi",
			"%r8d",
			"%r9d",
			"%r10d",
			"%r11d",
			"%r12d",
			"%r13d",
			"%r14d",
			"%r15d",
			"%rax",
			"%rcx",
			"%rdx",
			"%rbx",
			"%rsp",
			"%rbp",
			"%rsi",
			"%rdi",
			"%r8",
			"%r9",
			"%r10",
			"%r11",
			"%r12",
			"%r13",
			"%r14",
			"%r15",
			"%eip",
			"%rip",
			"%es",
			"%cs",
			"%ss",
			"%ds",
			"%fs",
			"%gs",
			"%xmm0",
			"%xmm1",
			"%xmm2",
			"%xmm3",
			"%xmm4",
			"%xmm5",
			"%xmm6",
			"%xmm7",
			"%xmm8",
			"%xmm9",
			"%xmm10",
			"%xmm11",
			"%xmm12",
			"%xmm13",
			"%xmm14",
			"%xmm15",
			"%xmm16",
			"%xmm17",
			"%xmm18",
			"%xmm19",
			"%xmm20",
			"%xmm21",
			"%xmm22",
			"%xmm23",
			"%xmm24",
			"%xmm25",
			"%xmm26",
			"%xmm27",
			"%xmm28",
			"%xmm29",
			"%xmm30",
			"%xmm31",
			"%ymm0",
			"%ymm1",
			"%ymm2",
			"%ymm3",
			"%ymm4",
			"%ymm5",
			"%ymm6",
			"%ymm7",
			"%ymm8",
			"%ymm9",
			"%ymm10",
			"%ymm11",
			"%ymm12",
			"%ymm13",
			"%ymm14",
			"%ymm15",
			"%ymm16",
			"%ymm17",
			"%ymm18",
			"%ymm19",
			"%ymm20",
			"%ymm21",
			"%ymm22",
			"%ymm23",
			"%ymm24",
			"%ymm25",
			"%ymm26",
			"%ymm27",
			"%ymm28",
			"%ymm29",
			"%ymm30",
			"%ymm31",
			"%zmm0",
			"%zmm1",
			"%zmm2",
			"%zmm3",
			"%zmm4",
			"%zmm5",
			"%zmm6",
			"%zmm7",
			"%zmm8",
			"%zmm9",
			"%zmm10",
			"%zmm11",
			"%zmm12",
			"%zmm13",
			"%zmm14",
			"%zmm15",
			"%zmm16",
			"%zmm17",
			"%zmm18",
			"%zmm19",
			"%zmm20",
			"%zmm21",
			"%zmm22",
			"%zmm23",
			"%zmm24",
			"%zmm25",
			"%zmm26",
			"%zmm27",
			"%zmm28",
			"%zmm29",
			"%zmm30",
			"%zmm31",
			"%k0",
			"%k1",
			"%k2",
			"%k3",
			"%k4",
			"%k5",
			"%k6",
			"%k7",
			"%bnd0",
			"%bnd1",
			"%bnd2",
			"%bnd3",
			"%cr0",
			"%cr1",
			"%cr2",
			"%cr3",
			"%cr4",
			"%cr5",
			"%cr6",
			"%cr7",
			"%cr8",
			"%cr9",
			"%cr10",
			"%cr11",
			"%cr12",
			"%cr13",
			"%cr14",
			"%cr15",
			"%dr0",
			"%dr1",
			"%dr2",
			"%dr3",
			"%dr4",
			"%dr5",
			"%dr6",
			"%dr7",
			"%dr8",
			"%dr9",
			"%dr10",
			"%dr11",
			"%dr12",
			"%dr13",
			"%dr14",
			"%dr15",
			"%st(0)",
			"%st(1)",
			"%st(2)",
			"%st(3)",
			"%st(4)",
			"%st(5)",
			"%st(6)",
			"%st(7)",
			"%mm0",
			"%mm1",
			"%mm2",
			"%mm3",
			"%mm4",
			"%mm5",
			"%mm6",
			"%mm7",
			"%tr0",
			"%tr1",
			"%tr2",
			"%tr3",
			"%tr4",
			"%tr5",
			"%tr6",
			"%tr7",
			"%st",
		};

		public static readonly string[] AllRegistersNaked = new string[DecoderConstants.NumberOfRegisters + 1] {
			"???",
			"al",
			"cl",
			"dl",
			"bl",
			"ah",
			"ch",
			"dh",
			"bh",
			"spl",
			"bpl",
			"sil",
			"dil",
			"r8b",
			"r9b",
			"r10b",
			"r11b",
			"r12b",
			"r13b",
			"r14b",
			"r15b",
			"ax",
			"cx",
			"dx",
			"bx",
			"sp",
			"bp",
			"si",
			"di",
			"r8w",
			"r9w",
			"r10w",
			"r11w",
			"r12w",
			"r13w",
			"r14w",
			"r15w",
			"eax",
			"ecx",
			"edx",
			"ebx",
			"esp",
			"ebp",
			"esi",
			"edi",
			"r8d",
			"r9d",
			"r10d",
			"r11d",
			"r12d",
			"r13d",
			"r14d",
			"r15d",
			"rax",
			"rcx",
			"rdx",
			"rbx",
			"rsp",
			"rbp",
			"rsi",
			"rdi",
			"r8",
			"r9",
			"r10",
			"r11",
			"r12",
			"r13",
			"r14",
			"r15",
			"eip",
			"rip",
			"es",
			"cs",
			"ss",
			"ds",
			"fs",
			"gs",
			"xmm0",
			"xmm1",
			"xmm2",
			"xmm3",
			"xmm4",
			"xmm5",
			"xmm6",
			"xmm7",
			"xmm8",
			"xmm9",
			"xmm10",
			"xmm11",
			"xmm12",
			"xmm13",
			"xmm14",
			"xmm15",
			"xmm16",
			"xmm17",
			"xmm18",
			"xmm19",
			"xmm20",
			"xmm21",
			"xmm22",
			"xmm23",
			"xmm24",
			"xmm25",
			"xmm26",
			"xmm27",
			"xmm28",
			"xmm29",
			"xmm30",
			"xmm31",
			"ymm0",
			"ymm1",
			"ymm2",
			"ymm3",
			"ymm4",
			"ymm5",
			"ymm6",
			"ymm7",
			"ymm8",
			"ymm9",
			"ymm10",
			"ymm11",
			"ymm12",
			"ymm13",
			"ymm14",
			"ymm15",
			"ymm16",
			"ymm17",
			"ymm18",
			"ymm19",
			"ymm20",
			"ymm21",
			"ymm22",
			"ymm23",
			"ymm24",
			"ymm25",
			"ymm26",
			"ymm27",
			"ymm28",
			"ymm29",
			"ymm30",
			"ymm31",
			"zmm0",
			"zmm1",
			"zmm2",
			"zmm3",
			"zmm4",
			"zmm5",
			"zmm6",
			"zmm7",
			"zmm8",
			"zmm9",
			"zmm10",
			"zmm11",
			"zmm12",
			"zmm13",
			"zmm14",
			"zmm15",
			"zmm16",
			"zmm17",
			"zmm18",
			"zmm19",
			"zmm20",
			"zmm21",
			"zmm22",
			"zmm23",
			"zmm24",
			"zmm25",
			"zmm26",
			"zmm27",
			"zmm28",
			"zmm29",
			"zmm30",
			"zmm31",
			"k0",
			"k1",
			"k2",
			"k3",
			"k4",
			"k5",
			"k6",
			"k7",
			"bnd0",
			"bnd1",
			"bnd2",
			"bnd3",
			"cr0",
			"cr1",
			"cr2",
			"cr3",
			"cr4",
			"cr5",
			"cr6",
			"cr7",
			"cr8",
			"cr9",
			"cr10",
			"cr11",
			"cr12",
			"cr13",
			"cr14",
			"cr15",
			"dr0",
			"dr1",
			"dr2",
			"dr3",
			"dr4",
			"dr5",
			"dr6",
			"dr7",
			"dr8",
			"dr9",
			"dr10",
			"dr11",
			"dr12",
			"dr13",
			"dr14",
			"dr15",
			"st(0)",
			"st(1)",
			"st(2)",
			"st(3)",
			"st(4)",
			"st(5)",
			"st(6)",
			"st(7)",
			"mm0",
			"mm1",
			"mm2",
			"mm3",
			"mm4",
			"mm5",
			"mm6",
			"mm7",
			"tr0",
			"tr1",
			"tr2",
			"tr3",
			"tr4",
			"tr5",
			"tr6",
			"tr7",
			"st",
		};
	}
}
#endif
