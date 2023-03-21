using Reloaded.Memory.Sigscan;
using Reloaded.Memory.Sources;
using System;

namespace Sonic3Din2D_Helper
{
    partial class Watchers
    {
        private ExternalMemory memory { get; set; }
        private IntPtr base_address { get; set; }

        public Watchers()
        {
            GameProcess = new ProcessHook();
        }

        /// <summary>
        /// This function is essentially equivalent of the init descriptor in script-based autosplitters.
        /// Everything you want to be executed when the game gets hooked needs to be put here.
        /// The main purpose of this function is to perform sigscanning and get memory addresses and offsets
        /// needed by the autosplitter.
        /// </summary>
        private void GetAddresses()
        {
            var scanner = new Scanner(game, game.MainModule).FindPattern("8B 3D ?? ?? ?? ?? 8B 0C 87");
            
            if (!scanner.Found)
                throw new NullReferenceException();

            memory = new ExternalMemory(game);

            memory.Read<int>((nuint)(int)game.MainModule.BaseAddress + (nuint)scanner.Offset + 2, out var _base_address);
            base_address = (IntPtr)_base_address;
        }

        private T ReadPath<T>(ExternalMemory memory, IntPtr base_address, params int[] offsets) where T : unmanaged
        {
            memory.Read((nuint)(int)base_address, out int addr);

            if (addr == 0)
                return default;

            for (var i = 0; i < offsets.Length - 1; i++)
            {
                memory.Read((nuint)addr + (nuint)offsets[i], out addr);

                if (addr == 0)
                    return default;
            }

            memory.Read((nuint)addr + (nuint)offsets[offsets.Length - 1], out T value);

            return value;
        }

        public void SetNiceLives()
        {
            var life = ReadPath<int>(memory, base_address, 0x4, 0x1AC, 0x2A4, 0x258);

            if (life == 0)
                return;

            memory.Read<int>((nuint)life, out var value);
            if (value == -6970)
                return;
            
            memory.Write((nuint)life, -6970);
        }

        public void SetShield(byte value)
        {
            var gl = ReadPath<int>(memory, base_address, 0, 0x268);
            
            if (gl == 0)
                return;

            memory.Read<byte>((nuint)gl + 0x288, out var _value);
            if (_value == value)
                return;

            memory.Write((nuint)gl + 0x288, value);
        }

        public void BossCheckPoint()
        {
            var gl = ReadPath<int>(memory, base_address, 0, 0x268);

            if (gl == 0)
                return;

            memory.Read<short>((nuint)gl + 0x2C8, out var splitidentifier);
            
            if (splitidentifier == 0)
                return;

            short checkpointx;// = 30;
            short checkpointy;// = 9999;

            switch (splitidentifier)
            {

                case 1: /* GG1 */
                    checkpointx = 9240;
                    checkpointy = 1102;
                    break;
                case 2: /* GG2 */
                    checkpointx = 9159;
                    checkpointy = 277;
                    break;
                case 3: /* RR1 */
                    checkpointx = 11093;
                    checkpointy = 931;
                    break;
                case 4: /* RR2 */
                    checkpointx = 6178;
                    checkpointy = 359;
                    break;
                case 5: /* SS1 */
                    checkpointx = 12260;
                    checkpointy = 642;
                    break;
                case 6: /* SS2 */
                    checkpointx = 12200;
                    checkpointy = 770;
                    break;
                case 7: /* DD1 */
                    checkpointx = 23863;
                    checkpointy = 634;
                    break;
                case 8: /* DD2 */
                    checkpointx = 7998;
                    checkpointy = 1930;
                    break;
                case 9: /* VV1 */
                    checkpointx = 8106;
                    checkpointy = 2562;
                    break;
                case 10: /* VV2 */
                    checkpointx = 5641;
                    checkpointy = 279;
                    break;
                case 11: /* GeGa1 */
                    checkpointx = 6528;
                    checkpointy = 994;
                    break;
                case 12: /* GeGa2 */
                    checkpointx = 6752;
                    checkpointy = 882;
                    break;
                case 13: /* PP1 */
                    checkpointx = 15952;
                    checkpointy = 498;
                    break;
                case 14: /* PP2 */
                    checkpointx = 16672;
                    checkpointy = 466;
                    break;
                default:
                    return;
            }

            memory.Write((nuint)gl + 0x58, checkpointx);
            memory.Write((nuint)gl + 0x68, checkpointy);
            memory.Write((nuint)gl + 0x48, (byte)1);
        }

        public void DD1CheckPoint()
        {
            var gl = ReadPath<int>(memory, base_address, 0, 0x268);

            if (gl == 0)
                return;

            memory.Read<short>((nuint)gl + 0x2C8, out var splitidentifier);

            if (splitidentifier == 0)
                return;

            short checkpointx = 30;
            short checkpointy = 9999;

            if (splitidentifier == 7)
            {
                checkpointx = 12200;
                checkpointy = 500;
            }

            memory.Write((nuint)gl + 0x58, checkpointx);
            memory.Write((nuint)gl + 0x68, checkpointy);
            memory.Write((nuint)gl + 0x48, (byte)1);
        }

        public void SetGameComplete()
        {
            var gl = ReadPath<int>(memory, base_address, 0, 0x268);

            if (gl == 0)
                return;

            memory.Read<byte>((nuint)gl + 0x278, out byte value);
            if (value == 3)
                return;

            memory.Write((nuint)gl + 0x278, (byte)3);
        }
    }
}