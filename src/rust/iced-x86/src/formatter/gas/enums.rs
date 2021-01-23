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

use core::fmt;

// GENERATOR-BEGIN: CtorKind
// ⚠️This was generated by GENERATOR!🦹‍♂️
#[derive(Copy, Clone, Eq, PartialEq)]
#[allow(non_camel_case_types)]
#[allow(dead_code)]
pub(crate) enum CtorKind {
	Previous,
	Normal_1,
	Normal_2a,
	Normal_2b,
	Normal_2c,
	Normal_3,
	AamAad,
	asz,
	bnd,
	ST_STi,
	DeclareData,
	er_2,
	er_4,
	far,
	imul,
	maskmovq,
	movabs,
	nop,
	OpSize,
	OpSize2_bnd,
	OpSize3,
	os,
	STi_ST,
	sae,
	CC_1,
	CC_2,
	CC_3,
	os_jcc_1,
	os_jcc_2,
	os_jcc_3,
	os_loopcc,
	os_loop,
	os_mem,
	Reg16,
	os_mem2,
	os2_3,
	os2_4,
	STIG1,
	pblendvb,
	pclmulqdq,
	pops,
	mem16,
	Reg32,
}
#[rustfmt::skip]
static GEN_DEBUG_CTOR_KIND: [&str; 43] = [
	"Previous",
	"Normal_1",
	"Normal_2a",
	"Normal_2b",
	"Normal_2c",
	"Normal_3",
	"AamAad",
	"asz",
	"bnd",
	"ST_STi",
	"DeclareData",
	"er_2",
	"er_4",
	"far",
	"imul",
	"maskmovq",
	"movabs",
	"nop",
	"OpSize",
	"OpSize2_bnd",
	"OpSize3",
	"os",
	"STi_ST",
	"sae",
	"CC_1",
	"CC_2",
	"CC_3",
	"os_jcc_1",
	"os_jcc_2",
	"os_jcc_3",
	"os_loopcc",
	"os_loop",
	"os_mem",
	"Reg16",
	"os_mem2",
	"os2_3",
	"os2_4",
	"STIG1",
	"pblendvb",
	"pclmulqdq",
	"pops",
	"mem16",
	"Reg32",
];
impl fmt::Debug for CtorKind {
	#[inline]
	fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_CTOR_KIND[*self as usize])?;
		Ok(())
	}
}
impl Default for CtorKind {
	#[must_use]
	#[inline]
	fn default() -> Self {
		CtorKind::Previous
	}
}
// GENERATOR-END: CtorKind

// GENERATOR-BEGIN: SizeOverride
// ⚠️This was generated by GENERATOR!🦹‍♂️
#[derive(Copy, Clone, Eq, PartialEq)]
#[allow(non_camel_case_types)]
#[allow(dead_code)]
pub(crate) enum SizeOverride {
	None,
	Size16,
	Size32,
	Size64,
}
#[rustfmt::skip]
static GEN_DEBUG_SIZE_OVERRIDE: [&str; 4] = [
	"None",
	"Size16",
	"Size32",
	"Size64",
];
impl fmt::Debug for SizeOverride {
	#[inline]
	fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_SIZE_OVERRIDE[*self as usize])?;
		Ok(())
	}
}
impl Default for SizeOverride {
	#[must_use]
	#[inline]
	fn default() -> Self {
		SizeOverride::None
	}
}
// GENERATOR-END: SizeOverride

// GENERATOR-BEGIN: InstrOpInfoFlags
// ⚠️This was generated by GENERATOR!🦹‍♂️
pub(crate) struct InstrOpInfoFlags;
#[allow(dead_code)]
impl InstrOpInfoFlags {
	pub(crate) const NONE: u32 = 0x0000_0000;
	pub(crate) const MNEMONIC_SUFFIX_IF_MEM: u32 = 0x0000_0001;
	pub(crate) const SIZE_OVERRIDE_MASK: u32 = 0x0000_0003;
	pub(crate) const OP_SIZE_SHIFT: u32 = 0x0000_0001;
	pub(crate) const OP_SIZE16: u32 = 0x0000_0002;
	pub(crate) const OP_SIZE32: u32 = 0x0000_0004;
	pub(crate) const OP_SIZE64: u32 = 0x0000_0006;
	pub(crate) const ADDR_SIZE_SHIFT: u32 = 0x0000_0003;
	pub(crate) const ADDR_SIZE16: u32 = 0x0000_0008;
	pub(crate) const ADDR_SIZE32: u32 = 0x0000_0010;
	pub(crate) const ADDR_SIZE64: u32 = 0x0000_0018;
	pub(crate) const INDIRECT_OPERAND: u32 = 0x0000_0020;
	pub(crate) const OP_SIZE_IS_BYTE_DIRECTIVE: u32 = 0x0000_0040;
	pub(crate) const KEEP_OPERAND_ORDER: u32 = 0x0000_0080;
	pub(crate) const JCC_NOT_TAKEN: u32 = 0x0000_0100;
	pub(crate) const JCC_TAKEN: u32 = 0x0000_0200;
	pub(crate) const BND_PREFIX: u32 = 0x0000_0400;
	pub(crate) const IGNORE_INDEX_REG: u32 = 0x0000_0800;
	pub(crate) const MNEMONIC_IS_DIRECTIVE: u32 = 0x0000_1000;
}
// GENERATOR-END: InstrOpInfoFlags

// GENERATOR-BEGIN: InstrOpKind
// ⚠️This was generated by GENERATOR!🦹‍♂️
#[derive(Copy, Clone, Eq, PartialEq)]
#[allow(non_camel_case_types)]
#[allow(dead_code)]
pub(crate) enum InstrOpKind {
	Register,
	NearBranch16,
	NearBranch32,
	NearBranch64,
	FarBranch16,
	FarBranch32,
	Immediate8,
	Immediate8_2nd,
	Immediate16,
	Immediate32,
	Immediate64,
	Immediate8to16,
	Immediate8to32,
	Immediate8to64,
	Immediate32to64,
	MemorySegSI,
	MemorySegESI,
	MemorySegRSI,
	MemorySegDI,
	MemorySegEDI,
	MemorySegRDI,
	MemoryESDI,
	MemoryESEDI,
	MemoryESRDI,
	Memory64,
	Memory,
	Sae,
	RnSae,
	RdSae,
	RuSae,
	RzSae,
	DeclareByte,
	DeclareWord,
	DeclareDword,
	DeclareQword,
}
#[rustfmt::skip]
static GEN_DEBUG_INSTR_OP_KIND: [&str; 35] = [
	"Register",
	"NearBranch16",
	"NearBranch32",
	"NearBranch64",
	"FarBranch16",
	"FarBranch32",
	"Immediate8",
	"Immediate8_2nd",
	"Immediate16",
	"Immediate32",
	"Immediate64",
	"Immediate8to16",
	"Immediate8to32",
	"Immediate8to64",
	"Immediate32to64",
	"MemorySegSI",
	"MemorySegESI",
	"MemorySegRSI",
	"MemorySegDI",
	"MemorySegEDI",
	"MemorySegRDI",
	"MemoryESDI",
	"MemoryESEDI",
	"MemoryESRDI",
	"Memory64",
	"Memory",
	"Sae",
	"RnSae",
	"RdSae",
	"RuSae",
	"RzSae",
	"DeclareByte",
	"DeclareWord",
	"DeclareDword",
	"DeclareQword",
];
impl fmt::Debug for InstrOpKind {
	#[inline]
	fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_INSTR_OP_KIND[*self as usize])?;
		Ok(())
	}
}
impl Default for InstrOpKind {
	#[must_use]
	#[inline]
	fn default() -> Self {
		InstrOpKind::Register
	}
}
// GENERATOR-END: InstrOpKind
