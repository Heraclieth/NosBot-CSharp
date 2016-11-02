using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nos_CSharp
{
    class map
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

        private uint MAP_ID;
        private uint MOB_AMOUNT;
        private uint PLAYER_AMOUNT;
        private uint NPC_AMOUNT;
        private uint ITEM_AMOUNT;
        private string LIST_PLAYER;
        private string LIST_NPC;
        private int LIST_PLAYER_O;

        #region get / set
        public uint MAP_ID1
        {
            get
            {
                return MAP_ID;
            }

            set
            {
                MAP_ID = value;
            }
        }

        public uint MOB_AMOUNT1
        {
            get
            {
                return MOB_AMOUNT;
            }

            set
            {
                MOB_AMOUNT = value;
            }
        }

        public uint PLAYER_AMOUNT1
        {
            get
            {
                return PLAYER_AMOUNT;
            }

            set
            {
                PLAYER_AMOUNT = value;
            }
        }

        public uint NPC_AMOUNT1
        {
            get
            {
                return NPC_AMOUNT;
            }

            set
            {
                NPC_AMOUNT = value;
            }
        }

        public uint ITEM_AMOUNT1
        {
            get
            {
                return ITEM_AMOUNT;
            }

            set
            {
                ITEM_AMOUNT = value;
            }
        }

        public string LIST_PLAYER1
        {
            get
            {
                return LIST_PLAYER;
            }

            set
            {
                LIST_PLAYER = value;
            }
        }

        public string LIST_NPC1
        {
            get
            {
                return LIST_NPC;
            }

            set
            {
                LIST_NPC = value;
            }
        }

        public int LIST_PLAYER_O1
        {
            get
            {
                return LIST_PLAYER_O;
            }

            set
            {
                LIST_PLAYER_O = value;
            }
        }
        #endregion

        public void chercheMapInfo()
        {
            uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);
            int processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id);

            var mapId_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x69278C, mapId_buffer, 4, 0);
            MAP_ID = (uint)BitConverter.ToInt32(mapId_buffer, 0);

            var amob_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x81FCEC, amob_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(amob_buffer, 0) + 0x10, amob_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(amob_buffer, 0) + 0x08, amob_buffer, 4, 0);
            MOB_AMOUNT = (uint)BitConverter.ToInt32(amob_buffer, 0);

            var aplayer_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x81FCEC, aplayer_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(aplayer_buffer, 0) + 0xC, aplayer_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(aplayer_buffer, 0) + 0x08, aplayer_buffer, 4, 0);
            PLAYER_AMOUNT = (uint)BitConverter.ToInt32(aplayer_buffer, 0);

            var anpc_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x81FCEC, anpc_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(anpc_buffer, 0) + 0x14, anpc_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(anpc_buffer, 0) + 0x08, anpc_buffer, 4, 0);
            NPC_AMOUNT = (uint)BitConverter.ToInt32(anpc_buffer, 0);

            var aitem_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x81FCEC, aitem_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(aitem_buffer, 0) + 0x18, aitem_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(aitem_buffer, 0) + 0x08, aitem_buffer, 4, 0);
            ITEM_AMOUNT = (uint)BitConverter.ToInt32(aitem_buffer, 0);

            LIST_PLAYER_O = 0x00;
            var lPlayers_buffer = new byte[15];
            ReadProcessMemory(processHandle, 0x81FCEC, lPlayers_buffer, 15, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + 0xC, lPlayers_buffer, 15, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + 0x04, lPlayers_buffer, 15, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + LIST_PLAYER_O, lPlayers_buffer, 15, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + 0x1CC, lPlayers_buffer, 15, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + 0x0, lPlayers_buffer, 15, 0);
            LIST_PLAYER = Encoding.UTF8.GetString(lPlayers_buffer);

            }
        }
    }
}
