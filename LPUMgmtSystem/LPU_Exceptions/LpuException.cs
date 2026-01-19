namespace LPU_Exceptions
{
    /// <summary>
    /// Custom Exception Class created for Lpu project By Devika on Date 29/12/2025 at 11.34 AM
    ///
    /// </summary>
    public class LpuException : Exception
    {
        public LpuException():base()//Constructor chaining
        {

        }
        public LpuException(string errorMsg) : base(errorMsg)
        {

        }
    }
}