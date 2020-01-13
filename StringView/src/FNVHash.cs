using System;
namespace ModTheGungeon {
    public static class FNVHash {
        // http://isthe.com/chongo/tech/comp/fnv/
        public const uint FNV_PRIME = 16777619;
        public const uint FNV_OFFSET_BASIS = 2166136261;

        public static uint Compute(StringView s) {
            var hash = FNV_OFFSET_BASIS;
            for (var i = 0; i < s.Length; i++) {
                var octet = (byte)s[i];
                hash = hash * FNV_PRIME;
                hash = hash ^ octet;
            }
            return hash;
        }

        public static uint Compute(string s, int i = 0, int len = -1) {
            var hash = FNV_OFFSET_BASIS;
            if (len < -1) len = s.Length;
            for (; i < len; i++) {
                var octet = (byte)s[i];
                hash = hash * FNV_PRIME;
                hash = hash ^ octet;
            }
            return hash;
        }
    }
}
