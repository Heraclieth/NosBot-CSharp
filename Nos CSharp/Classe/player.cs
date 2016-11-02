using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nos_CSharp
{
    class player
    {
        const int PROCESS_WM_READ = 0x0010;
        #region DLLs Import
        [DllImport("kernel32.dll")]
        public static extern int OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);
        #endregion
        static Process[] p = Process.GetProcessesByName("nostalex.dat");

        uint DELETE = 0x00010000;
        uint READ_CONTROL = 0x00020000;
        uint WRITE_DAC = 0x00040000;
        uint WRITE_OWNER = 0x00080000;
        uint SYNCHRONIZE = 0x00100000;
        uint END = 0xFFF;


        private string NICKNAME;
        private uint PLAYER_ID;

        private uint HP;
        private uint HP_MAX;
        private uint MP;
        private uint MP_MAX;

        private uint EXP;

        private uint GOLD;

        private uint PLAYER_LVL;
        private uint PLAYER_JLVL;
        private uint TARGET_ID;
        private string NPC_TARGET_NAME;
        private string PLAYER_TARGET_NAME;

        private uint POSITION;
        private uint TARGET;

        #region GET /SET
        public string NICKNAME1
        {
            get
            {
                return NICKNAME;
            }

            set
            {
                NICKNAME = value;
            }
        }

        public uint PLAYER_ID1
        {
            get
            {
                return PLAYER_ID;
            }

            set
            {
                PLAYER_ID = value;
            }
        }

        public uint HP1
        {
            get
            {
                return HP;
            }

            set
            {
                HP = value;
            }
        }

        public uint HP_MAX1
        {
            get
            {
                return HP_MAX;
            }

            set
            {
                HP_MAX = value;
            }
        }

        public uint MP1
        {
            get
            {
                return MP;
            }

            set
            {
                MP = value;
            }
        }

        public uint MP_MAX1
        {
            get
            {
                return MP_MAX;
            }

            set
            {
                MP_MAX = value;
            }
        }

        public uint PLAYER_ID2
        {
            get
            {
                return PLAYER_ID;
            }

            set
            {
                PLAYER_ID = value;
            }
        }

        public uint GOLD1
        {
            get
            {
                return GOLD;
            }

            set
            {
                GOLD = value;
            }
        }

        public uint PLAYER_LVL1
        {
            get
            {
                return PLAYER_LVL;
            }

            set
            {
                PLAYER_LVL = value;
            }
        }

        public uint PLAYER_JLVL1
        {
            get
            {
                return PLAYER_JLVL;
            }

            set
            {
                PLAYER_JLVL = value;
            }
        }

        public uint TARGET_ID1
        {
            get
            {
                return TARGET_ID;
            }

            set
            {
                TARGET_ID = value;
            }
        }

        public string NPC_TARGET_NAME1
        {
            get
            {
                return NPC_TARGET_NAME;
            }

            set
            {
                NPC_TARGET_NAME = value;
            }
        }

        public uint POSITION1
        {
            get
            {
                return POSITION;
            }

            set
            {
                POSITION = value;
            }
        }

        public string PLAYER_TARGET_NAME1
        {
            get
            {
                return PLAYER_TARGET_NAME;
            }

            set
            {
                PLAYER_TARGET_NAME = value;
            }
        }

        public uint EXP1
        {
            get
            {
                return EXP;
            }

            set
            {
                EXP = value;
            }
        }

        public uint TARGET1
        {
            get
            {
                return TARGET;
            }

            set
            {
                TARGET = value;
            }
        }
        #endregion

        public void cherchePlayerInfo()
        {
            uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);
            int processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id);

            var hp_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x8200AC, hp_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(hp_buffer, 0) + 0xAC, hp_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(hp_buffer, 0) + 0x4C, hp_buffer, 4, 0);
            HP = (uint)BitConverter.ToInt32(hp_buffer, 0);

            var hpmax_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x8200AC, hpmax_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(hpmax_buffer, 0) + 0xAC, hpmax_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(hpmax_buffer, 0) + 0x48, hpmax_buffer, 4, 0);
            HP_MAX = (uint)BitConverter.ToInt32(hpmax_buffer, 0);

            var mp_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x8200AC, mp_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(mp_buffer, 0) + 0xB0, mp_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(mp_buffer, 0) + 0x4C, mp_buffer, 4, 0);
            MP = (uint)BitConverter.ToInt32(mp_buffer, 0);

            var mpmax_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x8200AC, mpmax_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(mpmax_buffer, 0) + 0xB0, mpmax_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(mpmax_buffer, 0) + 0x48, mpmax_buffer, 4, 0);
            MP_MAX = (uint)BitConverter.ToInt32(mpmax_buffer, 0);

            var nickname_buffer = new byte[15];
            ReadProcessMemory(processHandle, 0x68D554, nickname_buffer, 15, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(nickname_buffer, 0) + 0x00, nickname_buffer, 15, 0);
            NICKNAME = Encoding.UTF8.GetString(nickname_buffer);

            var playerId_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x820058, playerId_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(playerId_buffer, 0) + 0x24, playerId_buffer, 4, 0);
            PLAYER_ID = (uint)BitConverter.ToInt32(playerId_buffer, 0);

            var gold_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x820114, gold_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(gold_buffer, 0) + 0x128, gold_buffer, 4, 0);
            GOLD = (uint)BitConverter.ToInt32(gold_buffer, 0);

            var lvl_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x820644, lvl_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(lvl_buffer, 0) + 0x34, lvl_buffer, 4, 0);
            PLAYER_LVL = (uint)BitConverter.ToInt32(lvl_buffer, 0);

            var jlvl_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x820270, jlvl_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(jlvl_buffer, 0) + 0x194, jlvl_buffer, 4, 0);
            PLAYER_JLVL = (uint)BitConverter.ToInt32(jlvl_buffer, 0);

            var targetId_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x8200B0, targetId_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(targetId_buffer, 0) + 0x130, targetId_buffer, 4, 0);
            TARGET_ID = (uint)BitConverter.ToInt32(targetId_buffer, 0);

            var npc_target_buffer = new byte[30];
            ReadProcessMemory(processHandle, 0x8200B0, npc_target_buffer, 30, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(npc_target_buffer, 0) + 0x12C, npc_target_buffer, 30, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(npc_target_buffer, 0) + 0xa8, npc_target_buffer, 30, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(npc_target_buffer, 0) + 0x08, npc_target_buffer, 30, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(npc_target_buffer, 0) + 0x04, npc_target_buffer, 30, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(npc_target_buffer, 0) + 0x00, npc_target_buffer, 30, 0);
            NPC_TARGET_NAME = Encoding.UTF8.GetString(npc_target_buffer);

            var player_target_buffer = new byte[30];
            ReadProcessMemory(processHandle, 0x691DDC, player_target_buffer, 30, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(player_target_buffer, 0) + 0x34, player_target_buffer, 30, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(player_target_buffer, 0) + 0x1CC, player_target_buffer, 30, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(player_target_buffer, 0) + 0x00, player_target_buffer, 30, 0);
            PLAYER_TARGET_NAME = Encoding.UTF8.GetString(player_target_buffer);

            var pos_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x820058, pos_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(pos_buffer, 0) + 0x04, pos_buffer, 4, 0);
            POSITION = (uint)BitConverter.ToInt32(pos_buffer, 0);

            var exp_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x820328, exp_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(exp_buffer, 0) + 0xAC, exp_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(exp_buffer, 0) + 0x68, exp_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(exp_buffer, 0) + 0x88, exp_buffer, 4, 0);
            EXP = (uint)BitConverter.ToInt32(exp_buffer, 0);

            var target_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x8200B0, target_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt16(target_buffer, 0) + 0x60, target_buffer, 4, 0);
            TARGET = (uint)BitConverter.ToInt32(target_buffer, 0);
        }



    }
}

