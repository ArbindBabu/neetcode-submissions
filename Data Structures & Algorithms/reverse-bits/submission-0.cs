public class Solution 
{
    public uint ReverseBits(uint n) 
    {
        uint result = 0;
        for(int i = 0; i < 32; i++)
        {
            uint bit = n & 1;

            result = (result <<= 1)| bit;
            n >>= 1;
        }
        return result;
    }
}
