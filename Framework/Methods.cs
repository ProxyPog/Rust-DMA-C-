using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Framework
{
    internal class Methods
    {
        public static void changeFov()
        {
            
        }

        public static void changeTime(float time)
        {

            ulong i = Memory.Read<ulong>(Offsets.GameAssembly + 0x3AC4730, Offsets.vmm, Offsets.processPid);
            ulong b = Memory.Read<ulong>(i + 0xB8, Offsets.vmm, Offsets.processPid);

            if (Memory.Write(b, time, Offsets.vmm, Offsets.processPid))
            {
            }
            else
            {
            }
        }
    }
}
