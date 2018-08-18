using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rrCS
{
    [TestClass]
    public class Types
    {

        /// <summary>
        /// <para> Value types https://docs.microsoft.com/dotnet/csharp/language-reference/language-specification/types#value-types </para>
        /// </summary>
        [TestMethod]
        public void ValueTypes()
        {
            const bool valBool8 = false;

            const sbyte valInt8 = 0;
            const short valInt16 = 0;
            const int valInt32 = 0;
            const long valInt64 = 0L;

            const byte valUint8 = 0;
            const ushort valUint16 = 0;
            const uint valUint32 = 0u;
            const ulong valUint64 = 0uL;

            const char valChar16 = '\x0000';

            const float valFloat32 = 0.0f;
            const double valFloat64 = 0.0d;

            const decimal valDecimal128 = 0.0m;
        }

    }
}
