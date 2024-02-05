using Gee.External.Capstone;
using Gee.External.Capstone.Arm;
using Gee.External.Capstone.Arm64;
using Gee.External.Capstone.X86;
using System;
using System.Collections.Generic;
using System.Text;

namespace QConverter {

    public enum Arch {
        ARM,
        ARM64,
        X86,
        X86_64
    }

    public class Instruction {
        public Instruction() { }
        public Instruction(long addr, string mnem, string op) {
            this.Address = addr;
            this.Mnemonic = mnem;
            this.Operand = op;
        }
        public override string ToString() {
            return Mnemonic + " " + Operand;
        }
        public long Address { set; get; }
        public string Mnemonic { set; get; }
        public string Operand { set; get; }
        public byte[] Bytes { get; set; }
    }

    public class Disassembler : IDisposable {

        private CapstoneDisassembler disasm;
        private Arch arch;

        public Disassembler(Arch arch) {
            this.disasm = MakeForArch(arch);
            this.arch = arch;
        }

        private static CapstoneDisassembler MakeForArch(Arch arch) {
            switch (arch) {
                case Arch.ARM:
                    return CapstoneDisassembler.CreateArmDisassembler(ArmDisassembleMode.Arm);
                case Arch.ARM64:
                    return CapstoneDisassembler.CreateArm64Disassembler(Arm64DisassembleMode.LittleEndian);
                case Arch.X86_64:
                    return CapstoneDisassembler.CreateX86Disassembler(X86DisassembleMode.Bit64);
                default:
                    return CapstoneDisassembler.CreateX86Disassembler(X86DisassembleMode.Bit32);
            }
        }

        public Instruction[] Disassemble(byte[] data) {
            var instructions = new List<Instruction>();
            foreach (var inst in (object[])disasm.GetType().GetMethod("Disassemble", new Type[] { typeof(byte[]) })
                                                           .Invoke(disasm, new object[] { data })) {
                Instruction instr = new Instruction();
                foreach (var prop in inst.GetType().GetProperties()) {
                    var propRecord = instr.GetType().GetProperty(prop.Name);
                    if (propRecord != null)
                        propRecord.SetValue(instr, prop.GetValue(inst));
                }
                instructions.Add(instr);
            }
            return instructions.ToArray();
        }

        public string DisassembleToStr(byte[] data) {
            StringBuilder buff = new StringBuilder();
            foreach (var instr in Disassemble(data))
                buff.AppendLine(instr.ToString());
            return buff.ToString();
        }

        public void Dispose() {
            if (disasm != null) {
                disasm.Dispose();
                disasm = null;
            }
        }
    }
}