using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Nos_CSharp
{
    public class map
    {       
        #region DLLs Import
        [DllImport("kernel32.dll")]
        public static extern int OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);
        #endregion
        private Process[] p;

        private int PROCESS_WM_READ;
        private uint DELETE;
        private uint READ_CONTROL;
        private uint WRITE_DAC;
        private uint WRITE_OWNER;
        private uint SYNCHRONIZE;
        private uint END;

        private uint MAP_ID;
        private uint MOB_AMOUNT;
        private uint PLAYER_AMOUNT;
        private uint NPC_AMOUNT;
        private uint ITEM_AMOUNT;
        private uint SKILL_AMOUNT;

        private List<string> LIST_PLAYER;
        private int LIST_PLAYER_O;

        private List<string> LIST_NPC;
        private int LIST_NPC_O;

        private List<string> LIST_SKILL;
        private int LIST_SKILL_O;




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

        public List<string> LIST_PLAYER1
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

        public List<string> LIST_NPC1
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

        public int LIST_SKILL_O1
        {
            get
            {
                return LIST_SKILL_O;
            }

            set
            {
                LIST_SKILL_O= value;
            }
        }

        public int LIST_NPC_O1
        {
            get
            {
                return LIST_NPC_O;
            }

            set
            {
                LIST_NPC_O = value;
            }
        }

        public List<string> LIST_SKILL1
        {
            get
            {
                return LIST_SKILL;
            }

            set
            {
                LIST_SKILL = value;
            }
        }

        public uint SKILL_AMOUNT1
        {
            get
            {
                return SKILL_AMOUNT;
            }

            set
            {
                SKILL_AMOUNT = value;
            }
        }
        #endregion

        public map()
        {
            PROCESS_WM_READ = 0x0010;
            p = Process.GetProcessesByName("nostalex.dat");

            DELETE = 0x00010000;
            READ_CONTROL = 0x00020000;
            WRITE_DAC = 0x00040000;
            WRITE_OWNER = 0x00080000;
            SYNCHRONIZE = 0x00100000;
            END = 0xFFF;
        }

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

            var askill_buffer = new byte[4];
            ReadProcessMemory(processHandle, 0x820270, askill_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(askill_buffer, 0) + 0x158, askill_buffer, 4, 0);
            ReadProcessMemory(processHandle, BitConverter.ToInt32(askill_buffer, 0) + 0x14, askill_buffer, 4, 0);
            SKILL_AMOUNT = (uint)BitConverter.ToInt32(askill_buffer, 0);
                       

            }
        public List<string> playerListe()
        {
            uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);
            int processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id);

            LIST_PLAYER_O = 0x00;

            List<string> l_PlayersName = new List<string>();

            byte[] lPlayers_buffer = new byte[15];
            for (int i = 0; i < PLAYER_AMOUNT; i++)
            {
                ReadProcessMemory(processHandle, 0x81FCEC, lPlayers_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + 0xC, lPlayers_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + 0x04, lPlayers_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + LIST_PLAYER_O, lPlayers_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + 0x1CC, lPlayers_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lPlayers_buffer, 0) + 0x0, lPlayers_buffer, 15, 0);

                l_PlayersName.Add(Encoding.UTF8.GetString(lPlayers_buffer));

                LIST_PLAYER_O += 0x04;                         
            }

            return l_PlayersName;
        }

        public List<string> skillListe()
        {
            uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);
            int processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id);

            LIST_SKILL_O = 0xF0;

            List<string> l_SkillsName = new List<string>();

            byte[] lSkills_buffer = new byte[15];
            for (int j = 0; j < SKILL_AMOUNT; j++)
            {
                ReadProcessMemory(processHandle, 0x820270, lSkills_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lSkills_buffer, 0) + LIST_SKILL_O, lSkills_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lSkills_buffer, 0) + 0xA8, lSkills_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lSkills_buffer, 0) + 0x08, lSkills_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lSkills_buffer, 0) + 0x14, lSkills_buffer, 15, 0);
                ReadProcessMemory(processHandle, BitConverter.ToInt32(lSkills_buffer, 0) + 0x0, lSkills_buffer, 15, 0);

                l_SkillsName.Add(Encoding.UTF8.GetString(lSkills_buffer));

                LIST_SKILL_O += 0x04;
            }

            return l_SkillsName;
        }


        }
    }

